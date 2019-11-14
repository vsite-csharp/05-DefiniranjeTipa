using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            Osoba o = new Osoba();
            Console.WriteLine(o.Ime);
            Console.WriteLine(o.Prezime);
            Console.WriteLine(o.DatumRođenja);
        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, String datumRođenja)
        {
            Osoba os = new Osoba(ime, prezime, datumRođenja);
            Console.WriteLine(os.Ime);
            Console.WriteLine(os.Prezime);
            Console.WriteLine(os.DatumRođenja);
        }


        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom("Hrvoje", "Horvat", "21.3.2009");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
