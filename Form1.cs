using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        List<Sensor> Sensors;

        int AnalogSensors = 6;
        int DigitalSensors = 3;

        double LoggingTime = 8.0F;

        public Form1()
        {
            InitializeComponent();
            initSensors();

        }

        private void initSensors()
        {
            Sensors = new List<Sensor>();

            for (int i = 1; i <= AnalogSensors; i++)
            {
                Sensors.Add(new AnalogSensor(i));
            }
            for (int i = 1; i <= DigitalSensors; i++)
            {
                Sensors.Add(new DigitalSensor(i));
            }

        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            string Data = "";
            foreach (Sensor s in this.Sensors)
            {
                Data = Data + s.GetSensId() + " : " + Convert.ToString(s.GetValue()) + "\n";
            }
            TextBox.Text = Data;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
