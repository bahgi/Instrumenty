using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumenty
{
    public abstract class Instrument
    {
        private char _sound;

        public Instrument(char sound)
        {
            _sound = sound;
        }

        public string Pick { get; set; }

        public int Weight { get; set; }

        public virtual string Play()
        {
            var doubleSound = $"{_sound}{(char)(_sound + 1)}";
            Console.Write(doubleSound);
            return doubleSound;
        }
    }
}
