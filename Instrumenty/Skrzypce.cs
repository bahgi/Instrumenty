using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumenty
{
    public class Skrzypce : Instrument, ISkrzypce
    {

        public Skrzypce(char sound) : base(sound)
        {
            
        }

        //public override void Play()
        //{
        //    Console.WriteLine("\nTak grają skrzypce: ");
        //    base.Play();
        //}

        public void PlayOtherSound()
        {
            throw new NotImplementedException();
        }
    }

}
