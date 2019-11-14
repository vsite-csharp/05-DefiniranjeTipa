using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            Osoba o1 = new Osoba("","",DateTime.MinValue);
            Console.WriteLine(o1.Ime);
            Console.WriteLine(o1.Prezime);
            Console.WriteLine(o1.DatumRođenja);
        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
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
