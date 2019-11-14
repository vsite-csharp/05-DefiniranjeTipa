﻿using System;
using System.Globalization;
using System.Threading;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KorištenjeObjekata
    {
        
        public static void IspišiTrenutniDatumVrijeme()
        {
            Console.WriteLine(DateTime.Now);
        }

        
        public static void IspišiDanašnjiDatum()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        
        public static void IspišiTrenutnoVrijeme()
        {
             Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static int IzračunajBrojDanaIzmeđuDvaDatuma(int godina1, int mjesec1, int dan1, int godina2, int mjesec2, int dan2)
        {

            // TODO:003 Stvoriti objekt "datum1" tipa DateTime tako da se njegovom konstruktoru proslijede godina1, mjesec1 i dan1.

            // TODO:004 Stvoriti objekt "datum2" tipa DateTime tako da se njegovom konstruktoru proslijede godina2, mjesec2 i dan2.

            // TODO:005 Izračunati razliku između datum1 i datum2 (jednostavnim oduzimanjem: datum2 - datum1) i tu razliku dodijeliti varijabli "period" tipa TimeSpan (koja služi za pohranu vremenskog perioda).

            // TODO:006 Budući da metoda mora kao rezultat vratiti izračunati period izražen kao broj dana, iz prethodno izračunatog perioda treba dohvatiti i vratiti svojstvo Days (tj. svojstvo TimeSpan.Days).
            return 0;
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hr");

            IspišiTrenutniDatumVrijeme();

            IspišiDanašnjiDatum();

            IspišiTrenutnoVrijeme();

            Console.WriteLine(IzračunajBrojDanaIzmeđuDvaDatuma(2015, 5, 1, 2016, 5, 1));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

    }
}
