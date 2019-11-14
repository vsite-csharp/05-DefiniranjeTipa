using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            Osoba person = new Osoba();
            Console.WriteLine(person.Ime);
            Console.WriteLine(person.Prezime);
            Console.WriteLine(person.DatumRođenja);

        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            Osoba person2 = new Osoba("myles", "kennedy", new DateTime(1998, 4, 18));
            Console.WriteLine(person2.Ime);
            Console.WriteLine(person2.Prezime);
            Console.WriteLine(person2.DatumRođenja);
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
