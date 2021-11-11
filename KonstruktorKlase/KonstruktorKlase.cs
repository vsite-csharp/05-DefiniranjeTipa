using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            // :060 Stvoriti objekt klase Osoba i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            //Osoba person = new Osoba();
            //Console.WriteLine(person.Ime);
            //Console.WriteLine(person.Prezime);
            //Console.WriteLine(person.DatumRođenja);

        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // :063 Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba person = new Osoba(ime, prezime, datumRođenja );
            Console.WriteLine(person.Ime);
            Console.WriteLine(person.Prezime);
            Console.WriteLine(person.DatumRođenja);

        }

        // :064 Pokrenuti testove i provjeriti prolazi li test u grupi TestKonstruktoraKlase

        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom("Hrvoje", "Horvat", new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
