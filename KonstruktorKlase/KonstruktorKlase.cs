using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            DateTime datum = new DateTime(1765, 12, 3);
            
            Osoba o1 = new Osoba("Milan","Bandić",datum);
            Console.WriteLine(o1.Ime);
            Console.WriteLine(o1.Prezime);
            Console.WriteLine(o1.DatumRođenja);

        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // TODO:063 Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            DateTime datum = new DateTime(1765, 12, 3);

            Osoba o1 = new Osoba(ime, prezime, datumRođenja);
            Console.WriteLine(o1.Ime);
            Console.WriteLine(o1.Prezime);
            Console.WriteLine(o1.DatumRođenja);
        }


        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom("Hrvoje", "Horvat", new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
