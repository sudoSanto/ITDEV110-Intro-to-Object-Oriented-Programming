using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowAPP
{
    //Matthew Dal Santo
    //ITDEV110
    //Assignment 7
    class HighLowAdmin
    {
        public HighLowAdmin() { }

        HighLowView View = new HighLowView();

        int height = Console.WindowHeight;

        public void HLInit()
        {
            Console.Title = "High Low Guessing Game";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetWindowSize(110, height);
            View.ViewSetup();
        }
    }
}
