using System;

namespace Instrumenty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mojaGitara=new Gitara ('a');
            mojaGitara.Play();

            var mojeSkrzypce=new Skrzypce ('c');
            mojeSkrzypce.Play();

            var mojePianino=new Pianino ('g');
            mojePianino.Play();
            
            Console.ReadKey();
        }
        
    }
}
