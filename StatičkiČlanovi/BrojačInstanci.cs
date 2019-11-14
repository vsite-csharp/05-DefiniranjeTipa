using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        static private int brojac = 0;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojac);
        }

        private int instanca;

        public BrojačInstanci()
        {
            ++brojac;
            instanca = brojac;
        }

        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
