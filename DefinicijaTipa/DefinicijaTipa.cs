﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // :010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        int broj;


        // TODO:011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        

    }


    struct MojaStruktura
    {
        // TODO:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        private string tekst = "MojaStruktura";
        // TODO:014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }

        public MojaStruktura(string tekst)
        {
            var ms = new MojaStruktura();
        }

    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // :012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan
            var mk = new MojaKlasa();
            mk.IspišiČlan();


        }

        public static void IspišiČlanStrukture()
        {
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            var ms = new MojaStruktura();
            ms.IspišiČlan();

        }

        // TODO:016 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
