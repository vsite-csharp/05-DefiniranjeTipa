using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    
    struct MojaStruktura
    {
		public string tekst;
		public MojaStruktura(string s)
		{
			tekst = s;
		}
		public void IspisiClan()
		{
			Console.WriteLine(tekst);
		}

    }

   
    class MojaKlasa
    {
		public int br = 5;
		public void IspisiClan()
		{
			Console.WriteLine(br);
		}
    }

    class ClassStruct
    {
        public static void IspišiStrukture()
        {
            
            MojaStruktura ms1 = new MojaStruktura("Moja struktura");
            MojaStruktura ms2 = ms1;
			ms1.IspisiClan();
			ms2.IspisiClan();
            

            Console.WriteLine();
            
            ms2.tekst = "MyStruct";
			ms1.IspisiClan();
			ms2.IspisiClan();

		}

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
			mk1.IspisiClan();
			mk2.IspisiClan();

			Console.WriteLine();
			
			mk2.br = 2;
			
			mk1.IspisiClan();
			mk2.IspisiClan();
		}

        static void Main(string[] args)
        {
            IspišiStrukture();
            Console.WriteLine();

            IspišiKlase();
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
