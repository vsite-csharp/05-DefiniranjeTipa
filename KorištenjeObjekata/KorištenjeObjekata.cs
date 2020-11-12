using System;
using System.Globalization;
using System.Threading;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KorištenjeObjekata
    {
        
        public static void IspišiTrenutniDatumVrijeme()
        {
            var sad = DateTime.Now;
            Console.WriteLine(sad);
        }

        
        public static void IspišiDanašnjiDatum()
        {
            var sad = DateTime.Now;
            Console.WriteLine(sad.ToShortDateString());
        }

        
        public static void IspišiTrenutnoVrijeme()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static int IzračunajBrojDanaIzmeđuDvaDatuma(int godina1, int mjesec1, int dan1, int godina2, int mjesec2, int dan2)
        {
            var datum1 = new DateTime(godina1, mjesec1, dan1);
            var datum2 = new DateTime(godina2, mjesec2, dan2);
            var period = datum2 - datum1;
            return period.Days;
        }

        
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            IspišiTrenutniDatumVrijeme();

            IspišiDanašnjiDatum();

            IspišiTrenutnoVrijeme();

            Console.WriteLine(IzračunajBrojDanaIzmeđuDvaDatuma(2015, 5, 1, 2016, 5, 1));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

    }
}
