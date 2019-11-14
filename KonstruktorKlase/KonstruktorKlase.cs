using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            // TODO:060 Stvoriti objekt klase Osoba i ispisati vrijednosti članova Ime, Prezime, DatumRođenja

        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // TODO:063 Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti članova Ime, Prezime, DatumRođenja

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
