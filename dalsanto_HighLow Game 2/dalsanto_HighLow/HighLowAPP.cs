using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace HighLowAPP
{
    //Matthew Dal Santo
    //ITDEV110
    //Assignment 7
    //
    //Apologies for the lack of comments.  I didn't have as much time as I would have liked.
    //
    //The var assignment for the sound objects was the only solution I could find.  I know you don't
    //like the var assignment, but I wasn't sure how else to create sounds.
    //
    class HighLowAPP
    {
        static void Main(string[] args)
        {
            HighLowAdmin Admin = new HighLowAdmin();

            HighLowControl Control = new HighLowControl();

            Admin.HLInit();

            Control.HLRun();
        }
    }
}
