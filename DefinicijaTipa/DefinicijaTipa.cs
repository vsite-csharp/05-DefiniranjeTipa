using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        private
            int broj = 5;
        // TODO:010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
       public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }

        // TODO:011 Zadati metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".

    }


    struct MojaStruktura
    {
        // TODO:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
       private 
            string tekst;
        public void IspišiČlan()
        {
            tekst = "MojaStruktura";
            Console.WriteLine(tekst);
        }
        // TODO:014 Zadati metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".

    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa obj = new MojaKlasa();
            obj.IspišiČlan();
            // TODO:012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan

        }

        public static void IspišiČlanStrukture()
        {
            MojaStruktura obj = new MojaStruktura();
            obj.IspišiČlan();
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".

        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
