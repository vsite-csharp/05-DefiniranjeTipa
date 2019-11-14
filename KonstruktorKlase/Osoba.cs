using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public Osoba(string ime,string prezime, DateTime DatumRodenja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRođenja = DatumRodenja;
        }
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;


    }
}
