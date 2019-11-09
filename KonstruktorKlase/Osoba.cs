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
            Ime = "Pero";
            Prezime = "Peric";
            DatumRođenja = new DateTime(1990, 7, 5);
        }
        
        
        public Osoba(string ime,string prezime,DateTime datumrođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumrođenja;
        }
    }
}
