using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj = 5;
        // Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {
            Console.WriteLine(broj); 
        }

    }


    struct MojaStruktura
    {
        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }
        // Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        private string tekst;// = "MojaStruktura";

        // Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // TODO:012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan
            MojaKlasa mk = new MojaKlasa();
            mk.IspišiČlan();
        }

        public static void IspišiČlanStrukture()
        {
            // Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            MojaStruktura ms = new MojaStruktura("MojaStruktura");
            ms.IspišiČlan();
        }

        //Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
