using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace databaseBackup
{
    class File
    {
        public string[] ReadFileParametersBD()
        {
            StreamReader f = new StreamReader("Parameters.txt");
            string[] Parameters = new string[4];
            int i = 0;
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                Parameters[i] = s;
                i++;
            }
            f.Close();
            return Parameters;
        }
        public void WriteFileIntervalSave(int interval, DateTime time)
        {
            StreamWriter f = new StreamWriter("IntervalTools.txt", false);
            f.WriteLine(interval.ToString());
            f.WriteLine(time.ToString());
            f.Close();
        }
        public string[] ReadFileIntervalSave()
        {
            StreamReader f = new StreamReader("IntervalTools.txt");
            string[] Parameters = new string[2];
            int i = 0;
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                Parameters[i] = s;
                i++;
            }
            f.Close();
            return Parameters;
        }
    }
}
