using System;

namespace LV3
{
    class zadatak1LV3
    {
        private static void Main(string[] args)
        {            
            Dataset p1 = new Dataset("csv.txt");
            Dataset p2 = (Dataset)p1.Clone();

            p1.Print();
            p2.Print();
            p1.ClearData(); //s ovim pozivom kod funkcije p1.print
                            //neće ispisati ništa nego će samo ispisati p2.print 
            p1.Print();
            p2.Print();       
        }
    }
}
