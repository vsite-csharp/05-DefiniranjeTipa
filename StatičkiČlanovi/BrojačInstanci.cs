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

        // TODO:054 U metodu dodati naredbu koja će ispisati vrijednost člana "instanca"
        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
