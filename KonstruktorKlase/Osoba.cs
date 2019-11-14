using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        //AKO JE READONLY MOZE SE SAMO INICIJALIZIRATI U KONSTRUKTORU I TO JE TO
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()
        {
            Ime = "Tin";
            Prezime = "Levacic";
            DatumRođenja = new DateTime(1971, 7, 4);
        }
        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
        public Osoba(string ime,string prezime,DateTime datum)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datum;
        }
    }
}
