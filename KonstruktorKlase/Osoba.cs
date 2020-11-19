using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()
        {
        //    Ime = "pero";
        //    Prezime = "Horvat";
        //    DatumRođenja = new DateTime(1985, 3, 21);
        }
        // Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
        public Osoba(string ime, string prezime, DateTime datum)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datum;
        }
    }
}
