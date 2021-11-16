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
        //SaStatičkimKonstruktorom1.Metoda1 -> prva metoda je static i može se pozvati bez instanciranja objekta
        //SaStatičkimKonstruktorom2.Metoda2 -> druga metoda nije static te se za njen poziv treba instancirati objekt

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
