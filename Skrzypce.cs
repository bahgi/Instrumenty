using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumenty
{
    public class Skrzypce : Instrument
    {

        public Skrzypce(char sound) : base(sound)
        {
            
        }
        public override void Play()
        {
            Console.WriteLine("\nTak grają skrzypce: ");
            base.Play();
        }

        public override void PlayOtherSound()
        {
            throw new NotImplementedException();
        }
    }

}
