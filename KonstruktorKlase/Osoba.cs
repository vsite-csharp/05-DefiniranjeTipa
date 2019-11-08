using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
       public Osoba()
        {
            Ime = "Pero";
            Prezime = "Peric";
            DatumRođenja = new DateTime(1990, 7, 5);
        }
        
        
        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
        public Osoba(string ime,string prezime,DateTime datumrođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumrođenja;
        }
    }
}
