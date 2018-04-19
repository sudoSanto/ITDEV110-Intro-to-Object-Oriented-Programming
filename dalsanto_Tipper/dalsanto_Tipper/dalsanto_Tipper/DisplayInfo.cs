using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TipperApp
{
    class DisplayInfo
    {
        //I don't want anything in the constructor as I'm calling the class later.
        public DisplayInfo() {}

        public void FormatInfo(double Tot, double Tip, double TipAndTot, string RestName)
        {
            //Just put this in here so it wasn't such an abrupt transition.
            Console.Clear();
            Console.WriteLine("Calculating...");
            Thread.Sleep(1000);
            Console.Clear();

            //As per your comment on my previous assignment
            //and what we've learned in class I changed my var assignment to string for time.
            string todaytime = DateTime.Now.ToString("HH:mm tt");
            Console.WriteLine("\nRestaurant Name: " + RestName);
            Console.WriteLine("Current Time: " + todaytime);
            Console.WriteLine("Bill Total: $" + Tot);
            Console.WriteLine("Tip Amount(at 15%): $" + Tip);
            Console.WriteLine("Total Including Tip: $" + TipAndTot);
        }//end FormatInfo
    }//end DisplayInfo
}//end namespace
