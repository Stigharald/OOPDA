using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        List<Sensor> Sensors; // just a list of virtual analog and digital sensors
        CSVfile Logfile; //lage loggefil objekt

        // Values given in assignment
        int AnalogSensors = 6; 
        int DigitalSensors = 3;

        double LoggingTime = 8.0F; //sec
        double Sampingtime = 2.8F; //sec

        double SampleTimeLeft = 0.0F; //Sec
        double LoggingTimeLeft = 0.0F; //sec

        // Methods in Form  


        bool Logging;
        bool Sampleable;

        public Form1()
        {
            InitializeComponent();
            initSensors();
            Logging = false;
            Sampleable = true;

            CheckboxLogging.Enabled = false;

            //initializing the tick intevall of the timers.
            TimerSample.Interval = Convert.ToInt16((Sampingtime*1000));
            TimerLogging.Interval = Convert.ToInt16((LoggingTime * 1000));

            //instansier loggefil objekt
            Logfile = new CSVfile("LoggeFil", Sensors);  //this makes and loggs and makes a header for the loggfile.

            TimerGui.Enabled = true;
        }

        private void initSensors()
        {
            Sensors = new List<Sensor>();

            for (int i = 1; i <= AnalogSensors; i++) //instansiate and put virtual analog-sensors into a list
            {
                Sensors.Add(new AnalogSensor(i)); // the i here is a seed number for random generator and indexer of the sensor
            }
            for (int i = 1; i <= DigitalSensors; i++) //instansiate and put virtual digital-sensors into a list
            {
                Sensors.Add(new DigitalSensor(i)); // i is same as in analog sensor
            }

        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            SampleSensors();

        }

        private void SampleSensors()
        {
            if (Sampleable)
            {
                string Data = "";
                foreach (Sensor s in this.Sensors)
                {
                    Data = Data + s.GetSensId() + " : " + Convert.ToString(s.GetValue()) + "\n";
                }
                TextBox.Text = Data;

                Sampleable = false;
                TimerSample.Enabled = true;
                SampleTimeLeft = Sampingtime-0.1F;
                //TimerLogging.Enabled = true;
                btnSample.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (Logging)
            {
                Logging = false;
                TimerLogging.Enabled = false;
                CheckboxLogging.Checked = false;
            }
            else {
                Logging = true;
                TimerLogging.Enabled = true;
                CheckboxLogging.Checked = true;
            }
        }

        private void TimerSample_Tick(object sender, EventArgs e)
        {
            Sampleable = true;
            TimerSample.Enabled = false;
            btnSample.Visible = true;
            if (checkBoxAutosample.Checked)
            {
                SampleSensors();
            }
        }

        private void TimerLogging_Tick(object sender, EventArgs e)
        {
            if (Logging)
            {
                Logfile.WriteToCSV(Sensors);
                LoggingTimeLeft = LoggingTime;
            }
        }

        private void TimerGui_Tick(object sender, EventArgs e)
        {
            if (SampleTimeLeft > 0.0F)
            {
                SampleTimeLeft -= 0.1F;
                lblSampletimeLeft.Text = Convert.ToString(string.Format("{0:N2}", SampleTimeLeft));
                lblLoggingLeftCaption.Text = "Sampling in:";
            }
            else
            {
                lblSampletimeLeft.Text = "";
                lblLoggingLeftCaption.Text = "";
            }

            if (LoggingTimeLeft > 0.0F)
            {
                LoggingTimeLeft -= 0.1F;
                lblLoggingTime.Text = Convert.ToString(string.Format("{0:N2}", LoggingTimeLeft));
                lblLoggingLeftCaption.Text = "Logging in";
            }
            else
            {
                lblLoggingTime.Text = "";
                lblLoggingLeftCaption.Text = "";
            }


        }


        // Add Timer for min time between samples


        // Add timer for loggint to file.


    }
}
