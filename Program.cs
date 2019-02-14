using System;
using System.Collections.Generic;
using System.Linq;

namespace Instrumenty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mojaGitara = new Gitara('a');
            mojaGitara.Play();

            var mojeSkrzypce = new Skrzypce('c');
            mojeSkrzypce.Play();

            Pianino mojePianino = new Pianino('g');
            mojePianino.Play();
            // Deklaracja
            Pianino mojePianino2;
            // Inicjalizacja
            mojePianino2 = new Pianino('f');

            List<IInstrument> mojeGitary = new List<IInstrument> { mojaGitara, mojaGitara, new Gitara('c') };

            var gitaryKtoreWaza5 = mojeGitary.Where(g => g.Weight == 5).ToList();
            //nowa lista, która przeszukuje liste moje Gitary i zapisuje tylko te, które mają wagę 5

            var gitaryPosortowane = mojeGitary.OrderBy(g => g.Weight).ToList();



            Console.ReadKey();
        }

    }
}
