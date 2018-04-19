using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_Assignment2
{
    class Getting2KnowUapp
    {
        static void Main(string[] args)
        {
            //Matthew Dal Santo
            //ITDEV110
            //Assingment 2

            //We were asked for the current time, not Date.
            var todaytime = DateTime.Now.ToString("HH:mm tt");
            Console.WriteLine(todaytime);
            AboutMe Me = new AboutMe();
            Console.ReadKey();

        }
    }
}
