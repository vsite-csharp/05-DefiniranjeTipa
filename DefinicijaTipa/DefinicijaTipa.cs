using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // TODO:010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj=5;

        // TODO:011 Zadati metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspisiClan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        // TODO:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
        //U STRUKTURI SE NE MOZE ODMAH INICIJALIZIRAT VARIJABLA I ODMAH SE MORAJU INICIJALIZIRA SVI CLANOVI
        private string tekst;
        public MojaStruktura(string t)
        {
        tekst=t;
        }
        // TODO:014 Zadati metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspisiClan()
        {
        Console.WriteLine(tekst);
        }
    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // TODO:012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan
            MojaKlasa mk=new MojaKlasa();
            mk.IspisiClan();
           

        }

        public static void IspišiČlanStrukture()
        {
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
             MojaStruktura ms=new MojaStruktura("MojaStruktura");
             ms.IspisiClan();
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
