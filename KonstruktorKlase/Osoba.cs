using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        internal Osoba()
        {
            Ime = "Pero";
            Prezime = "Perić";
            DatumRođenja = new DateTime(1990,10,10,16,55,00);
        }
        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
        internal Osoba(string ime, string prezime, DateTime datumRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
        }
    }
}
