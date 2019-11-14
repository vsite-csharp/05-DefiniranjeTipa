﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
    struct MojaStruktura
    {
        public string tekst;
        public MojaStruktura(string t)
        {
            tekst = t;
        }
        
        public void IspisiClan()
        {
            Console.WriteLine(tekst);
        }

    }

    // TODO:025 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public
    class MojaKlasa
    {
        public int broj = 5;
        public void IspisiClan()
        {
            Console.WriteLine(broj);
        }

    }

    class ClassStruct
    {
        public static void IspišiStrukture()
        {
            // TODO:021 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura"
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
            // TODO:022 Pozvati metodu IspišiČlan za obje instance
            ms1.IspisiClan();
            ms2.IspisiClan();
            Console.WriteLine();
            // TODO:023 Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            // TODO:024 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            ms1.IspisiClan();
            ms2.IspisiClan();
        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // TODO:026 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            mk1.IspisiClan();

            mk2.IspisiClan();
            // TODO:027 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // TODO:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.

            mk1.IspisiClan();
            mk2.IspisiClan();
        }

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
