using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly string DatumRođenja;

        public Osoba()
        {
            Ime = "Ivan";
            Prezime = "Mbrale";
            DatumRođenja = "2009.12.3";
        }
        public Osoba(string ime, string prezime, string datumRodenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRodenja;
        }
    }
}
