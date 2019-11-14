﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
    struct MojaStruktura
    {
        public MojaStruktura(string tekst){

            this.tekst = tekst;
         }
        private string tekst;

        public void IspišiČlan(){
            Console.WriteLine(tekst);
}

    }

    // TODO:025 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public
    class MojaKlasa
    {
        private int broj = 5;
        void IspišiČlan(){
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
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            Console.WriteLine();
            ms2.tekst = "MyStruct";

            ms1.IspišiČlan();
            ms2.IspišiČlan();
             
            // TODO:022 Pozvati metodu IspišiČlan za obje instance

            Console.WriteLine();
            // TODO:023 Otkomentirati donju naredbu.
            //ms2.tekst = "MyStruct";
            // TODO:024 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.

        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // TODO:026 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            Console.WriteLine();
            // TODO:027 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // TODO:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            ms1.IspišiČlan();
            ms2.IspišiČlan();
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
