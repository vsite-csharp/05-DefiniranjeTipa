﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public.
    struct MojaStruktura
    {
        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }


// TODO:013 Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"
private string tekst; //"MojaStruktura"
    // TODO:014 Zadati javnu metodu IspišiČlan tipa void i u njoj dodati naredbu koja će ispisati podatkovni član "tekst".
    public void IspišiČlan()
    {
        Console.WriteLine(tekst);
    }

// TODO:025 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public.
    class MojaKlasa
        {
            public int broj = 5;

            public void IspišiČlan()
            {
                Console.WriteLine(broj);
            }



}

    class ClassStruct
    {
        public static void IspišiStrukture()
        {
            // :021 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura".
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            // :022 Pozvati metodu IspišiČlan za obje instance (ms1 i ms2).
            ms1.IspišiČlan();
            ms2.IspišiČlan();

            Console.WriteLine();
            // TODO:023 Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            // TODO:024 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            ms1.IspišiČlan();
            ms2.IspišiČlan();
        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // TODO:026 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            Console.WriteLine();
            // TODO:027 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // TODO:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.

        }

        // TODO:029 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestClass_Struct.

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
}

