using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        public Osoba(string ime,string prezime,DateTime datum) {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datum;
        }
        public Osoba() {
            Ime = "ime";
            Prezime = "prezime";
            DatumRođenja =new DateTime(1992,10,11);
        }

    }
}
