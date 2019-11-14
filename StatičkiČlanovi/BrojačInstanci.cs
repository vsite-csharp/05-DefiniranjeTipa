using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        // TODO:050 Dodati privatni statički član "brojač" tipa int i inicijalizirati ga na 0
        private static int brojac = 0;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojac);
        }
        private int instanca;

        public BrojačInstanci()
        {
            instanca=++brojac;
        }

        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
