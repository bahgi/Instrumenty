using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;

namespace Instrumenty
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("consoleapp.log")
                .CreateLogger();

            //Console.WriteLine("Hello World!");

            //GitaraGraj();

            //var suma = Gitara.Add(2, 5);

            //var mojeSkrzypce = new Skrzypce('c');
            //mojeSkrzypce.Play();

            //Pianino mojePianino = new Pianino('g');
            //mojePianino.Play();
            //// Deklaracja
            //Pianino mojePianino2;
            //// Inicjalizacja
            //mojePianino2 = new Pianino('f');

            // =======================================================

            //var writer = new StreamWriter("file.txt");
            //writer.WriteLine("hello!");
            //writer.Flush();

            int i = 0;

            using (var reader = new StreamReader("file.txt"))
            {
                Log.Information("Liczenie linii pliku file.txt");
                while (reader.EndOfStream == false)
                {
                    reader.ReadLine();
                    i++;
                }
            }

            using (var writer = new StreamWriter("file.txt", true))
            {
                Log.Warning("Zapisywanie do pliku file.txt");
                writer.WriteLine("hello" + i + "!");
            }

            using (var reader = new StreamReader("file.txt"))
            {
                Log.Error("Wypisywanie zawartości pliku file.txt");
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }

            /////////////////////////////////////////////

            var gitara = new Gitara('c')
            {
                Weight = 5,
                Pick = "kostka"
            };

            Log.Information("Próba serializacji obiektu gitara", gitara);
            var gitaraJakoText = JsonConvert.SerializeObject(gitara);

            using (var writer = new StreamWriter("gitara.json"))
            {
                writer.Write(gitaraJakoText);
            }

            Console.ReadKey();
        }

        public static void GitaraGraj()
        {
            var mojaGitara = new Gitara('a');
            mojaGitara.Play();
        }

    }
}
