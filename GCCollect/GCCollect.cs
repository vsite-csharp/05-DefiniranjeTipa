﻿using System.Diagnostics;

namespace Vsite.CSharp.DefiniranjeTipa
{
    static class Program
    {
        // TODO:110 Staviti točku prekida (breakpoint) u destruktor klase KlasaSDestruktorm, pokrenuti program i pogledati zadnje ispise prije prekida izvođenja.
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");

            for (int i = 0; i < 1000; i++)
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            Console.WriteLine("*** Pozivamo GC.Collect() ***");
            Debug.WriteLine("*** Pozivamo GC.Collect() ***");

            // explicitno pozivamo sustav za skupljanje smeća
            // redoslijed uništavanja objekata nije unaprijed određen!
            GC.Collect();

            Debug.WriteLine("*** Završio je poziv GC.Collect()!!! ***");
            Console.WriteLine("Završio je poziv GC.Collect()!!!");
            Console.ReadKey();

            Debug.WriteLine("*** SADA JE KONAČNO!!! ***");
        }
    }
}
