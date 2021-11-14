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

        // TODO:090 Pokrenuti program, pogledati ispis i obrazložiti ga.
        //Ispis: SaStatickimKonstruktorom1.Metoda1
        //       SaStatickimKonstruktorom2.Metoda2
        //       GOTOVO!!!
        //Statičkoj metodi se može pristupati direktno,dok je za pristup nestatičkoj metodi 
        //potrebno inicijaliziratiinstancu klase pa preko nje pristupati.
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
