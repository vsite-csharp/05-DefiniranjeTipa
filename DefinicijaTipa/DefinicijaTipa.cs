using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        // TODO:010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj = 5;

        // TODO:011 Zadati metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        void IspišiČlan(){
            Console.WriteLine(broj);
            }                        
    }


    struct MojaStruktura
    {
        public MojaStruktura(string tekst){

            this.tekst = tekst;
         }
        private string tekst;

        public void IspišiČlan(){
            Console.WriteLine(tekst);
}

        // TODO:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"


        // TODO:014 Zadati metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".

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
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            var ms = new MojaStruktura("MojaStruktura");
            ms.IspišiČlan();
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
