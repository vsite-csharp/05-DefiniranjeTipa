﻿namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // TODO:010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5

        // TODO:011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".

    }


    struct MojaStruktura
    {
        // TODO:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"

        // TODO:014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".

    }


    static class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // TODO:012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan

        }

        public static void IspišiČlanStrukture()
        {
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".

        }

        // TODO:016 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
