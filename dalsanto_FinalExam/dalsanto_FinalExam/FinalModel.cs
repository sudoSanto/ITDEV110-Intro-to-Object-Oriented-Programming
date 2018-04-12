using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_FinalExam
{
    class FinalModel
    {
        //Matthew Dal Santo
        //ITDEV110
        //Assignment 7

        public FinalModel() { }

        private Boolean coreOn = true;
        public Boolean CoreOn { get { return coreOn; } set { coreOn = value; } }

        private Boolean editOn = true;
        public Boolean EditOn { get { return editOn; } set { editOn = value; } }

        private Boolean quitOn = false;
        public Boolean QuitOn { get { return quitOn; } set { quitOn = value; } }

        private int cursorStudent = 0;
        public int CursorStudent { get { return cursorStudent; } set { cursorStudent = value; } }

        private int cursorPos = 0;
        public int CursorPos { get { return cursorPos; } set { cursorPos = value; } }
        
    }
}
