using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        public Osoba(string ime, string prezime, DateTime datumrRodenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumrRodenja;
        }
    
    }
}
