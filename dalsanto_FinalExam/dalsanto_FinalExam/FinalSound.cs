using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_FinalExam
{
    class FinalSound
    {
        //Matthew Dal Santo
        //ITDEV110
        //Assignment 7

        public FinalSound() { }

        System.Media.SoundPlayer pIntro = new System.Media.SoundPlayer();

        public void playIntro()
        {
            pIntro.SoundLocation = @".\Intro.wav";
            pIntro.Play();
        }

    }
}
