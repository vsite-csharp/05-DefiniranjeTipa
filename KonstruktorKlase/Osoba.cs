using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly string DatumRođenja;

        
		public Osoba()
		{
			Ime = "Zarko";
			Prezime = "Zivancic";
			DatumRođenja = "23.3.1994";
		}
		public Osoba(string i,string p,string d)
		{
			Ime = i;
			Prezime = p;
			DatumRođenja = d;
		}
		
	}
}
