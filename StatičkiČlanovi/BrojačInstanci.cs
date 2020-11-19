using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        // Dodati privatni statički član "brojač" tipa int i inicijalizirati ga na 0
        private static int brojac = 0;

        // U metodu dodati naredbu koja će ispisati trenutnu vrijednost člana brojač
        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojac);
        }

        // U klasu dodati privatni član "instanca" tipa int
        private int instanca = 0;

        //  U konstruktor dodati naredbu koja će uvećati "brojač" za 1 i uvećanu vrijednost dodijeliti članu "instanca"
        public BrojačInstanci()
        {
            instanca = ++brojac;
        }

        // U metodu dodati naredbu koja će ispisati vrijednost člana "instanca"
        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }

        // Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestStatičkihČlanova
    }
}
