using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            Osoba osoba = new Osoba();
            Console.WriteLine(osoba.Ime);
            Console.WriteLine(osoba.Prezime);
            Console.WriteLine(osoba.DatumRođenja);
        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            Osoba osoba1 = new Osoba("Nikola", "Tesla", new DateTime(1856, 7, 10));
            Console.WriteLine(osoba1.Ime);
            Console.WriteLine(osoba1.Prezime);
            Console.WriteLine(osoba1.DatumRođenja);

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
