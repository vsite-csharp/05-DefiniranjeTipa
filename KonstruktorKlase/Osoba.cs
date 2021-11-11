using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
      public readonly string Ime;
      public readonly string Prezime;
      public readonly DateTime DatumRođenja;

    public Osoba(string ime, string prezime, DateTime datumRođenja)
    {
            //Ime = "Pero";
            //Prezime = "Horvat;
            // DatumRođenja = DateTime.Now
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
        }
        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
    }
}