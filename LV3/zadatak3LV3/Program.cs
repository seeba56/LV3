using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();
            logger.Log("Tekst koji se zapisuje u datoteku");
        }
    }
}
