using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_FinalExam
{
    class FinalApp
    {
        //Matthew Dal Santo
        //ITDEV110
        //Assignment 7

        static void Main(string[] args)
        {
            FinalAdmin Admin = new FinalAdmin();
            FinalControl Control = new FinalControl();

            Admin.InitApp();

            Control.Core();


        }
    }
}
