using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase //DZ
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            // TODO:060 Stvoriti objekt klase Osoba i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba o1 = new Osoba(); //f12
            
            Console.WriteLine(o1.Ime);
            Console.WriteLine(o1.Prezime);
            Console.WriteLine(o1.DatumRođenja);
            //1.1.0001. 0:00:00
        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // TODO:063 Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba o2 = new Osoba("Pero", "Perić", DateTime.MinValue);
            Console.WriteLine(o2.Ime);
            Console.WriteLine(o2.Prezime);
            Console.WriteLine(o2.DatumRođenja);
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
