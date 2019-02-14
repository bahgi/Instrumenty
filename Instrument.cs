using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumenty
{
    public abstract class Instrument
    { 
        private char _sound;
        public Instrument (char sound)
        {
            _sound=sound;
        }

        public virtual void Play ()
        {
            //char sound2 = (char)((int)(_sound+1));
            Console.Write ($"{_sound} {(char)(_sound+1)}");
        }

        public abstract void PlayOtherSound();



    }
}
