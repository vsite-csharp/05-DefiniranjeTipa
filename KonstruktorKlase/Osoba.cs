using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        public Osoba()
        {
            Ime = "Milan";
            Prezime = "Bandić";
            DatumRođenja = new DateTime(1756,12,1);
        }

        public Osoba(string ime, string prezime, DateTime datumRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
        }
    }
}
