﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
		public SaStatičkimKonstruktorom2()

		{
			Console.WriteLine("SaStatickimKonstruktorom2.KonstrokKlase");
		}

		static SaStatičkimKonstruktorom2()
		{
			Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");
		}
		// TODO:095 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.StatičkiKonstruktor"

		// TODO:096 Ponovno pokrenuti program i pogledati ispis

		public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
