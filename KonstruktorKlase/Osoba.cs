using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
	class Osoba
	{
		public readonly string Ime;
		public readonly string Prezime;
		public readonly DateTime DatumRođenja;

		public Osoba(string ime, string prezime, DateTime datumRodjenja)
		{
			Ime = ime;
			Prezime = prezime;
			DatumRođenja = datumRodjenja;
		}

        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
    }
}
