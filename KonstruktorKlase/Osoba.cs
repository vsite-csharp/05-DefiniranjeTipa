using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        //  Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()
        {
            Ime = "Milan";
            Prezime = "Bandidos";
            //DatumRođenja = DateTime.Now;
            DatumRođenja = new DateTime(1999, 12, 3);
        }

        public Osoba(string ime, string prezime, DateTime datum)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRođenja = datum;
        }

        //  Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.

    }
}
