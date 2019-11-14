using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
	class SaStatičkimKonstruktorom1
	{
		public SaStatičkimKonstruktorom1()

		{
			Console.WriteLine("SaStatickimKonstruktorom1.KonstrokKlase");
		}

		static SaStatičkimKonstruktorom1()
		{
			Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");
		}


		// TODO:093 Pokrenuti program i pogledati ispis

		public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }
}
