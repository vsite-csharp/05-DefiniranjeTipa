namespace Vsite.CSharp.DefiniranjeTipa
{
    static class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            // TODO:060 Stvoriti objekt klase Osoba i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba o = new Osoba();
            Console.WriteLine(o.Ime);
            Console.WriteLine(o.Prezime);
            Console.WriteLine(o.DatumRođenja);
        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // TODO:063 Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba o = new Osoba(ime, prezime, datumRođenja);
            Console.WriteLine(o.Ime);
            Console.WriteLine(o.Prezime);
            Console.WriteLine(o.DatumRođenja);
        }

        // TODO:064 Pokrenuti testove i provjeriti prolazi li test u grupi TestKonstruktoraKlase

        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom(ime: "Hrvoje", prezime: "Horvat", datumRođenja: new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
