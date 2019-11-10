using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public Osoba()
        {
            Ime = "sara";
            Prezime = "cu";
            DatumRođenja = new DateTime(1995, 26, 1);
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
