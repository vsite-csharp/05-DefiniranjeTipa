using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa // nemamo konstuktor - koristi se defultni - on će inicijalizirati donji član na 5
    {
        // 010 Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        private int broj = 5; // defaultno je private - zgodno je staviti private jer dajemo do znanja da nismo "zaboravili"
        // 011 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        public MojaStruktura(string tekst) // ne smije imati konstruktor bez parametara
        {
            this.tekst = tekst;
        }
        // 013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"

        private string tekst; // = "MojaStruktura" -> Za strukture ne mogu ovako inicijalizirati članove - treba mi konstruktor

        // 014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }

    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // 012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan
            MojaKlasa mk = new MojaKlasa();
            mk.IspišiČlan();
        }

        public static void IspišiČlanStrukture()
        {
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            MojaStruktura ms = new MojaStruktura("MojaStruktura"); // šaljem string u konstruktor
            ms.IspišiČlan();    // neće ispisati ništa ukoliko je u konstruktoru prazan parametar -> nema inicijalizacije 
                                // - po defaultu je null -> moramo definirati kontruktor
        }

        // TODO:016 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestDefinicijeTipa.

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
