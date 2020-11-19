using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        // 050 Dodati privatni statički član "brojač" tipa int i inicijalizirati ga na 0
        private static int brojac = 0;
        
        // 051 U metodu dodati naredbu koja će ispisati trenutnu vrijednost člana brojač
        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojac);
        }

        // 052 U klasu dodati privatni član "instanca" tipa int
        private int instanca = 0;

        // 053 U konstruktor dodati naredbu koja će uvećati "brojač" za 1 i uvećanu vrijednost dodijeliti članu "instanca"
        public BrojačInstanci()
        {
            instanca = ++brojac;
        }

        // 054 U metodu dodati naredbu koja će ispisati vrijednost člana "instanca"
        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }

        // 055 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestStatičkihČlanova
    }
}
