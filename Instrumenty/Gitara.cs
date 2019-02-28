using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Instrumenty
{
    public class Gitara : Instrument, IGitara
    {
        private string _pick;

        public Gitara (char sound) : base(sound)
        {
            
        }

        public string Pick
        {
            get => _pick;
            set => _pick = value;
        }

        public void PlayOtherSound()
        {
            
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
