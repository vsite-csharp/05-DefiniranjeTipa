﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Destruktor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            // TODO:101 Dodati for petlju koja će se ponoviti 100000 puta i unutar koje će se kreirati novi objekti tipa KlasaSDestruktorom. Pokrenuti program i provjeriti redni broj prvog uništenog objekta.
            for (int i =1; i < 10000; i++)
                {
            
                    var kd = new KlasaSDestruktorom();
                   }

            {
            }
            Console.ReadKey();
            Console.WriteLine("GOTOVO!!!");
            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
