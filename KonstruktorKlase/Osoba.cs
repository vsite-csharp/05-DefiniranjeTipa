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
            Osoba o1 = new Osoba("","",DateTime.MinValue);
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = new DateTime(1851, 5, 3 );
        }
    
    }
}
