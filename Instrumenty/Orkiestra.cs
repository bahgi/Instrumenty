using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumenty
{
    public class Orkiestra
    {
        private readonly IGitara _gitara;
        private readonly IPianino _pianino;
        private readonly ISkrzypce _skrzypce;

        public Orkiestra(IGitara gitara, IPianino pianino, ISkrzypce skrzypce)
        {
            _gitara = gitara;
            _pianino = pianino;
            _skrzypce = skrzypce;
        }

        public string Melodia { get; set; }

        public void PlayAllInstrument()
        {
            Melodia += _gitara.Play();
            Melodia += _pianino.Play();
            Melodia += _skrzypce.Play();
        }
    }
}
