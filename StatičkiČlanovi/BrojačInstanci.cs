﻿using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class BrojačInstanci
    {
        // :050 Dodati privatni statički član "brojač" tipa int i inicijalizirati ga na 0
        private static int brojač = 0; 

        // :051 U metodu dodati naredbu koja će ispisati trenutnu vrijednost člana brojač
        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojač); // jer je statički možemo mu pristupati direktno  
        }

        // :052 U klasu dodati privatni član "instanca" tipa int
        private int instanca = 0; // nije statički, svaki bjekt koji stvorimo imat će svoj član instanca

        // :053 U konstruktor dodati naredbu koja će uvećati "brojač" za 1 i uvećanu vrijednost dodijeliti članu "instanca"
        public BrojačInstanci()
        {
            instanca = ++brojač; // svaki put kad se stvori novi objekt, imat će član instanca i  za svaki novi objekt će se instanca povećati
            //svaka instanca ima svoj jedinstveni broj, možemo pratiti kada je objekt stvoren, možemo vidjeti koliko je objekata stvoreno 
        }

        // :054 U metodu dodati naredbu koja će ispisati vrijednost člana "instanca"
        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);

        }

        // :055 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestStatičkihČlanova
    }
}
