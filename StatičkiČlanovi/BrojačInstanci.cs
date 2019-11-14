using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        private static int brojac = 0;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojac);
        }

        private int instanca;
        public BrojačInstanci()
        {
            instanca = ++brojac;
        }

        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
