namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // :010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj = 5;
        // :011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan() 
        {
            Console.WriteLine(this.broj);
        }

    }


    struct MojaStruktura
    {
        // :013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        private string tekst = "MojaStruktura";
        public MojaStruktura() { }
        // :014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {
            Console.WriteLine(this.tekst);
        }
    }


    static class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa mojaklasa = new MojaKlasa();
            mojaklasa.IspišiČlan();
            // :012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan

        }

        public static void IspišiČlanStrukture()
        {
            MojaStruktura mojaStruktura = new MojaStruktura();
            mojaStruktura.IspišiČlan();
            // :015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".

        }

        // :016 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
