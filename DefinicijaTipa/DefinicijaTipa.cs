using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
		
		private int broj = 5;

		public void IspisiClan()
		{
			Console.WriteLine(broj);
		}
    }


    struct MojaStruktura
    {

		public MojaStruktura(string tekst) { this.tekst = "Moja struktura"; }


		private string tekst;

		public void IspisiClan()
		{
			Console.WriteLine(tekst);
		}
	}


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
			MojaKlasa mk = new MojaKlasa();
			mk.IspisiClan();
        }

        public static void IspišiČlanStrukture()
        {
			var ms = new MojaStruktura("MojaStruktura");
			ms.IspisiClan();
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
