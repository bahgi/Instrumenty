using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumenty
{  
    public class Pianino : Instrument, IPianino
    {

        public Pianino (char sound) : base(sound)
        {
            
        }

        public void PlayOtherSound()
        {
            throw new NotImplementedException();
        }
    }

}
