namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // DID_IT:010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj = 5;

        // DID_IT:011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }

    }


    struct MojaStruktura
    {
        // DID_IT:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        private string tekst = "MojaStruktura";

        public MojaStruktura() {}

        // DID_IT:014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }

    }


    static class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // DID_IT:012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan
            MojaKlasa mojaKlasa = new MojaKlasa();
            mojaKlasa.IspišiČlan();

        }

        public static void IspišiČlanStrukture()
        {
            // DID_IT:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            MojaStruktura mojaStruktura = new MojaStruktura();
            mojaStruktura.IspišiČlan();

        }

        // DID_IT:016 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
