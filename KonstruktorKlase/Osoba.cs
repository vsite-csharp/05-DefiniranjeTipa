﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba(string ime, string prezime, DateTime datumRodenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRodenja;
        }
        // Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
    }
}
