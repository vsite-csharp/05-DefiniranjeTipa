namespace Vsite.CSharp.DefiniranjeTipa
{
	// 020 Prekopirati kod strukture iz prethodnog primjera
	struct MojaStruktura
	{
		public MojaStruktura(string tekst) {
        this.tekst = tekst;
        }

		// :013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"

		public string tekst = "MojaStruktura";

		// :014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
		public void IspišiČlan()
		{
			Console.WriteLine(tekst);
		}

     

	}


    // 025 Prekopirati kod klase iz prethodnog primjera.
    // 026 Klasi dodati javnu metodu PromijeniČlan tipa void i u njoj napisati naredbu kojom će se podatkovni član "broj" promijeniti u vrijednost zadanu parametrom metode.
    class MojaKlasa
    {
		public int broj = 5;

		// :011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".

		public void IspišiČlan()
		{
			Console.WriteLine(broj);
		}

	}

    static class ClassStruct
    {
        public static void IspišiStrukture()
        {
	
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
            // 022 Pozvati metodu IspišiČlan za obje instance (ms1 i ms2).

            ms1.IspišiČlan();
            ms2.IspišiČlan();

            Console.WriteLine();
            // 023 Dodati poziv metode PromijeniČlan objekta ms2 i metodi proslijediti "MyStruct".

            ms2.tekst = "MyStruct";

			// 024 Ponovno pozvati metodu IspišiČlan za obje instance te provjeriti i obrazložiti ispise.
			ms1.IspišiČlan();
			ms2.IspišiČlan();


		}

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // 027 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            mk1.IspišiČlan();
            mk2.IspišiČlan();

			Console.WriteLine();
            // 028 Dodati poziv metode PromijeniČlan objekta mk2 i metodi proslijediti broj 2.

            mk2.broj = 2;

			// 029 Ponovno pozvati metodu IspišiČlan za obje instance te provjeriti i obrazložiti ispise.
			mk1.IspišiČlan();
			mk2.IspišiČlan();
		}

        // 029a Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestClass_Struct.

        static void Main(string[] args)
        {
            IspišiStrukture();
            Console.WriteLine();

            IspišiKlase();
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
