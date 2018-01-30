using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Sensor
    {
        public double dVal;
        public string sId;
        public Random randomSensnsValue;

        public double min = -5.0F;
        public double max = 5.0F;

        public MaFilter filter;

        public Sensor(int SeedId)
        {
            sId = Convert.ToString(SeedId);
            randomSensnsValue = new Random(SeedId);
            dVal = 0.0F;
            filter = new MaFilter(dVal);
        }

        public virtual double GetValue()
        {
            double NewVal = dVal;

            NewVal += randomSensnsValue.NextDouble()-0.5F;

            if (NewVal > max)
            {
               //Upper saturation
            }
            else if (NewVal < min)
            {
                // lower saturation
            }
            else
            {
                dVal = NewVal;
            }
                
            return filter.Value(dVal); //set new value to filter, and return filterd val
        }
        public virtual string GetSensId()
        {
            return sId;
        }
    }

    class DigitalSensor : Sensor
    {
        public DigitalSensor(int SeedId) 
            : base(SeedId)
        {
            
        }

        public override string GetSensId()
        {
            return "D"+sId;
        }
    }

    class AnalogSensor : Sensor
    {
        public AnalogSensor(int SeedId)
           : base(SeedId)
        {
            
        }
        public override string GetSensId()
        {
            return "A" + sId;
        }

        public override double GetValue()
        {
            double NewVal = dVal;

            // Add ADC..
            // since the system is setup to give a float between 0 and 1 witch is a 10th of the span given in the assignment.
            
            int ADCVal = Convert.ToInt16(10*(randomSensnsValue.NextDouble()-0.5F));
            double VoltageVal = ADCVal*0.009765625F; //change in Voltage value.
            NewVal += VoltageVal;
            
            //Simulating of ADC done.

            if (NewVal > base.max)
            {
                //Upper saturation
            }
            else if (NewVal < base.min)
            {
                // lower saturation
            }
            else
            {
                dVal = NewVal;
            }

            return filter.Value(dVal); //set new value to filter, and return filterd val
        }

    }

    class MaFilter // moving average filter class used in both analog and digital sensors.
    {
        private int MovingAverageOf = 5;// moving average of the last # samples
        private Queue<double> Numbers; // queue because of FIFO dynamics, and easy to work with.
        
        public MaFilter(double initVal)
        {
            Numbers = new Queue<double>();

            for (int i = 1; i < MovingAverageOf; i++)
            {
                Numbers.Enqueue(initVal); 
            }
        }

        public double Value(double NewVal)
        {
            // filterdata base 
            Numbers.Enqueue(NewVal);  
            Numbers.Dequeue();
            // Calculate the mean of the data inside the collection
            int cnt = 0;
            double sum = 0;
            foreach (double val in Numbers)
            {
                cnt++;
                sum += val;
            }
            return sum / cnt;
        }
    }
}
