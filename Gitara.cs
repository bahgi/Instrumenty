using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumenty
{
    public class Gitara : Instrument, IGitara
    { 

        public Gitara (char sound) : base(sound)
        {
            
        }

        public string Pick { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void PlayOtherSound()
        {
            throw new NotImplementedException();
        }
    }
}
