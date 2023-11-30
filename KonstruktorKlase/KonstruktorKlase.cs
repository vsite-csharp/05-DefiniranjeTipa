namespace Vsite.CSharp.DefiniranjeTipa
{
    static class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            // :060 Stvoriti objekt klase Osoba i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba netko = new Osoba();
            Console.WriteLine(netko.Ime + " " + netko.Prezime + " DatRod: " + netko.DatumRođenja);
        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // :063 Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba novaOsoba = new Osoba(ime, prezime, datumRođenja);
            Console.WriteLine(novaOsoba.Ime);
            Console.WriteLine(novaOsoba.Prezime);
            Console.WriteLine(novaOsoba.DatumRođenja);
        }

        // :064 Pokrenuti testove i provjeriti prolazi li test u grupi TestKonstruktoraKlase

        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom(ime: "Hrvoje", prezime: "Horvat", datumRođenja: new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
