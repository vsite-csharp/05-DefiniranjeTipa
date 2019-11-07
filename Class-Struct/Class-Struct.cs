using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    
    class MojaKlasa
    {
		public int broj = 5;
		public void IspisiClan()
		{
			Console.WriteLine(broj);
		}

	}

	
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
			mk1.IspisiClan();
			mk2.IspisiClan();
            


            Console.WriteLine();
			
			mk2.broj = 2;
			
			mk1.IspisiClan();
			mk2.IspisiClan();



		}

		public static void IspišiStrukture()
        {
            
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
			ms1.IspisiClan();
			ms2.IspisiClan();
            


            Console.WriteLine();
			
			ms2.tekst = "MyStruct";
			
			ms1.IspisiClan();
			ms2.IspisiClan();

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
