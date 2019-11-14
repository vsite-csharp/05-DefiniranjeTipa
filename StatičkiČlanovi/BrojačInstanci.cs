using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        private static int brojac = 0;
        int instanca;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojac);
        }

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
