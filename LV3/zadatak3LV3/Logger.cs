using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3LV3
{
    class Logger
    {
        private String filePath;
        private static Logger instance;
        private Logger(string filePath)
        {
            this.filePath = filePath;
        }
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger("Ivan.txt");
            }
            return instance;
        }
        public String Filepath
        {
            get { return filePath; }
            set { filePath = value; }

        }
        public void Log(string message)
        {
            using (System.IO.StreamWriter fileWriter =
           new System.IO.StreamWriter(this.filePath, true))
            {
                fileWriter.WriteLine(message);
            }


        }
    }
}
