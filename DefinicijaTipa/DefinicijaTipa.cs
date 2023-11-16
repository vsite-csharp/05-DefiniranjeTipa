namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // DONE:010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int num = 5;

        // DONE:011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {
            Console.WriteLine(num);
        } 
    }


    struct MojaStruktura
    {
        // DONE:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        private string tekst = "MojaStruktura";

        // DONE:014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        public MojaStruktura(){}
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }


    static class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // DONE:012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan
            var classObject = new MojaKlasa();
            classObject.IspišiČlan();

        }

        public static void IspišiČlanStrukture()
        {
            // DONE:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            var structObject = new MojaStruktura();
            structObject.IspišiČlan();
        }

        // DONE:016 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
