using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime; //readonly može se inicijalizirati samo u konstruktoru i nigdje poslije
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        public Osoba(string ime, string prezime, DateTime datumRođenja){
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
        }
    }
}
