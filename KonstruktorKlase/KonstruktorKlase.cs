﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            var osoba = new Osoba();
            Console.WriteLine(osoba.Ime);
            Console.WriteLine(osoba.Prezime);
            Console.WriteLine(osoba.DatumRođenja);
        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            var osoba = new Osoba(ime, prezime, datumRođenja);
            Console.WriteLine(osoba.Ime);
            Console.WriteLine(osoba.Prezime);
            Console.WriteLine(osoba.DatumRođenja);
        }


        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom("Hrvoje", "Horvat", new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
