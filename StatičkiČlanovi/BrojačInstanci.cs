using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
		
		private static int brojac = 0;
		private int instanca;

		
        public static void IspišiBrojStvorenihObjekata()
        {
			Console.WriteLine(brojac);
        }

       

        
        public BrojačInstanci()
        {
			instanca = brojac + 1;
        }

        
        public void IspišiRedniBrojObjekta()
        {
			Console.WriteLine(instanca);
        }
    }
}
