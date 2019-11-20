using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public Osoba()
        {
            Ime = "Netko";
            Prezime = "Netkovic";
            DatumRođenja = new DateTime(1970, 10, 10);
        }

        public Osoba(string ime, string prezime, DateTime datumRodenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRodenja;
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
    }
}
