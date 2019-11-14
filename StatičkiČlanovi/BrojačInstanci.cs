using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        private static int brojač = 0;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojač);
        }

        private int instanca;
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
