using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public
    class MojaKlasa
    {
		public int broj = 5;
		public void IspisiClan()
		{
			Console.WriteLine(broj);
		}

	}

	// TODO:024 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
	struct MojaStruktura
    {
		public string tekst;
		public MojaStruktura(string a)
		{
			tekst = a;
		}
		public void IspisiClan()
		{
			Console.WriteLine(tekst);

		}

	}

    class ClassStruct
    {
        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // TODO:021 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.


            Console.WriteLine();
            // TODO:022 Otkomentirati donju naredbu.
            //mk2.broj = 2;
            // TODO:023 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.


        }

        public static void IspišiStrukture()
        {
            // TODO:025 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura"
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            // TODO:026 Pozvati metodu IspišiČlan za obje instance


            Console.WriteLine();
            // TODO:027 Otkomentirati donju naredbu.
            //ms2.tekst = "MyStruct";
            // TODO:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.


        }

        static void Main(string[] args)
        {
            IspišiKlase();

            Console.WriteLine();

            IspišiStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
