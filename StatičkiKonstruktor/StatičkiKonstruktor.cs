using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class StatičkiKonstruktor
    {
        public static void PozoviSamoStatičkuMetodu()
        {
            SaStatičkimKonstruktorom1.Metoda1();
        }

        public static void PozoviNestatičkuMetodu()
        {
            SaStatičkimKonstruktorom2 sk = new SaStatičkimKonstruktorom2();
            sk.Metoda2();
        }

        // 090 Pokrenuti program, pogledati ispis i obrazložiti ga.
        // Pozivi statičke i nestatičke metode gdje klasa sa nestatičkom metodom nasljeđuje klasu s statičku metodu

        static void Main(string[] args)
        {
            PozoviSamoStatičkuMetodu();
            Console.WriteLine();
            PozoviNestatičkuMetodu();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
