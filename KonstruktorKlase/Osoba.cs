﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        
        public Osoba(string Ime,string Prezime,DateTime datumRođenja )
    {
        this.Ime = Ime;
        this.Prezime = Prezime;
        this.DatumRođenja = datumRođenja;
    }
    }
    
}
