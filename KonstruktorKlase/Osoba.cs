using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba(string ime, string prezime, DateTime datumRođenja)
        {
            //Ime = "Pero";
            //Prezime = "Horvat";
            //DatumRođenja = DateTime.Now;

            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
        }
        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
    }
}
