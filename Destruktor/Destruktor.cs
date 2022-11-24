using System;
using System.Data.Common;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Destruktor
    {
        static void Main(string[] args)
        {
            var mem = GC.GetGCMemoryInfo().TotalAvailableMemoryBytes;
            Console.WriteLine($"{ mem / 1024 / 1024}");

            Console.WriteLine("Ušao sam u 'Main'");
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            // Dodati for petlju koja će se ponoviti 100000 puta i unutar koje će se kreirati novi objekti tipa KlasaSDestruktorom.Pokrenuti program i provjeriti redni broj prvog uništenog objekta.
            for (int i = 0; i < 10000; i++)
            {
                KlasaSDestruktorom obj = new KlasaSDestruktorom();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
