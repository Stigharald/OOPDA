using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class CSVfile
    {
        string direcory;
        string filename;
        string path;
        public CSVfile(string fileNameNNforextention, List<Sensor> Sensors, string filepath = @"C:\")
        {
            //direcory = filepath;  if application running as admin or somethingsomth? 
            direcory = Directory.GetCurrentDirectory();
            filename = fileNameNNforextention;
            path = direcory + filename + ".csv";

            StringBuilder Header = new StringBuilder();
            Header.Append("DateTime"+";");
            
            foreach (Sensor S in Sensors)
            {
                Header.Append(S.GetSensId());
                Header.Append(';');  // colon since in colon separated values
            }

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            if (fs.CanWrite)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(Header + "\n");
                fs.Write(buffer,0,buffer.Length);
            }
          
            fs.Flush();
            fs.Close();

        }
        
        public void WriteToCSV(List<Sensor> Sensorlist)
        {
            StringBuilder Values = new StringBuilder();

            Values.Append(Convert.ToString(DateTime.Now) + ";");

            foreach (Sensor S in Sensorlist)
            {
                Values.Append(Convert.ToString(S.dVal));
                Values.Append(';');  // colon since in colon separated values
            }
            //Values.Append("\n");

            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            if (fs.CanWrite)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(Values+ "\n");
                fs.Write(buffer, 0, buffer.Length);
            }

            fs.Flush();
            fs.Close();

        }

    }
}
