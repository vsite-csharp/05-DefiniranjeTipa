using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
      public readonly string Ime;
      public readonly string Prezime;
      public readonly string DatumRođenja;

    public Osoba(string ime, string prezime, DateTime DatumRođenja)
        {
            //Ime = "Pero";
            //Prezime = "Horvat;
            // DatumRođenja = DateTime.Now
            Ime = ime;
            Prezime = prezime;
        }
        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
    }