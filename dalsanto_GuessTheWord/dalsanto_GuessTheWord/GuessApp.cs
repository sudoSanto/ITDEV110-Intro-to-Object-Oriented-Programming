using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_GuessTheWord
{
    class GuessApp
    {
        static void Main(string[] args)
        {
            GuessControl gControl = new GuessControl();

            gControl.runGuess();

        }
    }
}
