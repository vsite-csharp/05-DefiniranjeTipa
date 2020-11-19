using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    //  Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public.
    struct MojaStruktura
    {
        //this.tekst=tekst;
        public string tekst;
        //javnu metodu ispiši član...
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }

    }

    //  Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public.
    class MojaKlasa
    {
        //  Dodati privatno polje (field - podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5
        public int broj = 5;
        //  Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }

    class ClassStruct
    {
        public static void IspišiStrukture()
        {
            // TODO:021 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura".
            MojaStruktura ms1 = new MojaStruktura(/*"MojaStruktura"*/);
            MojaStruktura ms2 = ms1;
            // TODO:022 Pozvati metodu IspišiČlan za obje instance (ms1 i ms2).
            ms1.IspišiČlan();
            ms2.IspišiČlan();

            Console.WriteLine();
            // TODO:023 Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            // TODO:024 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.

        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            //  Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            

            Console.WriteLine();
            // Otkomentirati donju naredbu.
            mk2.broj = 2;
            //  Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
           

        }

        //  Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestClass_Struct.

        static void Main(string[] args)
        {
            IspišiStrukture();
            Console.WriteLine();

            IspišiKlase();
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
