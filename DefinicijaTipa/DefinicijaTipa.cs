using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj = 5;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }

        //  Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".

    }


    struct MojaStruktura
    {
        //  Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"

        //  Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".

        private string tekst;

        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }

        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan
            var mojaKlasa = new MojaKlasa();
            mojaKlasa.IspišiČlan();

        }

        public static void IspišiČlanStrukture()
        {
            // Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            var mojaStruktura = new MojaStruktura("MojaStruktura");
            mojaStruktura.IspišiČlan();
        }

        //  Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
