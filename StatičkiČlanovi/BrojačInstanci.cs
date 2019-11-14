using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        

        static private int brojač = 0;
        
        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojač);
        }

        
        private int instanca;
        //inicijalizirati u konstruktoru(dolje)

        
        public BrojačInstanci()
        {
            ++brojač;
            instanca = brojač;
        }

        
        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
