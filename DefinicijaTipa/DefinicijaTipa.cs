using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // :010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj = 5;


        // :011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }

    }


    struct MojaStruktura
    {
        // :013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        public MojaStruktura(string text)
        {
            this.text = text;
        }
        // :014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        private string text; // = "MojaStruktura";
        public void IspišiČlan()
        {
            Console.WriteLine(text);
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
            // :015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            var ms = new MojaStruktura();
            ms.IspišiČlan();

        }

        // :016 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
