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
            this.Ime = "Marko";
            this.Prezime = "Debil";
            this.DatumRođenja = new DateTime(1544, 12, 21);
        }

        public Osoba(string ime, string prezime, DateTime datum)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRođenja = datum;
        }
    }
}
