using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleNotification message = new ConsoleNotification("Ivan Šebetić", "Pale sam na svijetu", "Bio jednom jedan mali Pale sam na svijetu", DateTime.Now, Category.INFO, ConsoleColor.DarkYellow);
            NotificationManager Graditelj = new NotificationManager();

            Graditelj.Display(message);
        }
    }
}


