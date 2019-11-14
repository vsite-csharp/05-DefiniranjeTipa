using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        
		public Osoba()
		{
			Ime = "Zarko";
			Prezime = "Zivancic";
			DatumRođenja = new DateTime(1971, 7, 4);
		}
		public Osoba(string i,string p,DateTime d)
		{
			Ime = i;
			Prezime = p;
			DatumRođenja = d;
		}
		
	}
}
