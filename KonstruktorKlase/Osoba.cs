using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // 061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()
        {
            Ime = "Netko";
            Prezime = "Netkić";
            DatumRođenja = DateTime.Now;
        }

        public Osoba(string Ime, string Prezime, DateTime DatumRođenja)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.DatumRođenja = DatumRođenja;
        }
        // 062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
    }
}
