using System;
using System.Globalization;
using System.Threading;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KorištenjeObjekata
    {
        public static void IspišiTrenutniDatumVrijeme()
        {
            DateTime now = DateTime.Now;
           
        }

        public static void IspišiDanašnjiDatum()
        {
            DateTime dateToDisplay = DateTime.Now;
            Console.WriteLine("Displaying short date for {0} culture", Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine("{0}", dateToDisplay.ToShortDateString());
        }

        public static void IspišiTrenutnoVrijeme()
        {
            DateTime dateToDisplay = DateTime.Now;
            Console.WriteLine("Displaying short date for {0} culture", Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine("{0}", dateToDisplay.ToShortTimeString());
        }

        public static int IzračunajBrojDanaIzmeđuDvaDatuma(int godina1, int mjesec1, int dan1, int godina2, int mjesec2, int dan2)
        {
            DateTime object1 = new DateTime(godina1, mjesec1, dan1);
            DateTime object2 = new DateTime(godina2, mjesec1, dan1);
            TimeSpan period = object2 - object1;
            int days = period.Days;
            return days;
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
