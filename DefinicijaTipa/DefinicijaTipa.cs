using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
		
		private int broj = 5;
		public void IspisiClan(){
			Console.WriteLine(broj);
		}
		

	}


    struct MojaStruktura
    {
		
		private string tekst;
		public MojaStruktura(string a)
		{
			tekst = a;
		}
		public void IspisiClan() {
			Console.WriteLine(tekst);

		}

		

	}


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
			
			MojaKlasa obj = new MojaKlasa();
			obj.IspisiClan();

			
        }

        public static void IspišiČlanStrukture()
        {
			MojaStruktura obj = new MojaStruktura("MojaStruktura");
			obj.IspisiClan();
           
        }

        static void Main(string[] args)
        {
			
			IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
