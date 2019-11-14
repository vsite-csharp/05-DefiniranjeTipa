using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        private static int Brojač = 0;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(Brojač);
        }
        private int instanca;

        public BrojačInstanci()
        {
            Brojač++;
            instanca = Brojač;
        }

        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
