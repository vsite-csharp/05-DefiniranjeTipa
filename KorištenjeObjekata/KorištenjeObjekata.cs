using System;
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
            DateTime datum1 = new DateTime(godina1, mjesec1, dan1);
            DateTime datum2 = new DateTime(godina2, mjesec2, dan2);

            TimeSpan period = datum2 - datum1;
            // TODO:006 Budući da metoda mora kao rezultat vratiti izračunati period izražen kao broj dana, iz prethodno izračunatog perioda treba dohvatiti i vratiti svojstvo Days (tj. svojstvo TimeSpan.Days).
            return period.Days;
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
