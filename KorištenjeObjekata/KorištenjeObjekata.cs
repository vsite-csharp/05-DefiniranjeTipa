using System;
using System.Globalization;
using System.Threading;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KorištenjeObjekata
    {
        // 000 Ispisati trenutni datum i vrijeme pomoću statičkog svojstva DateTime.Now 
        
        // DateTime je struktura - Now je statičko svojstvo
        public static void IspišiTrenutniDatumVrijeme()
        {
            var sad = DateTime.Now;
            Console.WriteLine(sad); // ispisuje 17.11.2020.
        }

        // 001 Ispisati današnji datum pomoću statičkog svojstva DateTime.Now i metode DateTime.ToShortDateString
        public static void IspišiDanašnjiDatum()
        {
            var sad = DateTime.Now; // sad je objekt tipa DateTime
            Console.WriteLine(sad.ToShortDateString()); // ispisuje 17.11.2020.
        }

        // 002 Ispisati trenutno vrijeme pomoću statičkog svojstva DateTime.Now i metode DateTime.ToShortTimeString
        public static void IspišiTrenutnoVrijeme()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString()); // ispisuje 17.11.2020.
        }

        public static int IzračunajBrojDanaIzmeđuDvaDatuma(int godina1, int mjesec1, int dan1, int godina2, int mjesec2, int dan2)
        {
            // 003 Stvoriti objekt "datum1" tipa DateTime tako da se njegovom konstruktoru proslijede godina1, mjesec1 i dan1.
            var datum1 = new DateTime(godina1, mjesec1, dan1);

            // 004 Stvoriti objekt "datum2" tipa DateTime tako da se njegovom konstruktoru proslijede godina2, mjesec2 i dan2.
            var datum2 = new DateTime(godina2, mjesec2, dan2);

            // 005 Izračunati razliku između datum1 i datum2 (jednostavnim oduzimanjem: datum2 - datum1) i tu razliku dodijeliti varijabli "period" tipa TimeSpan (koja služi za pohranu vremenskog perioda).
            var period = datum2 - datum1; // period je objekt tipa TimeSpan

            // 006 Budući da metoda mora kao rezultat vratiti izračunati period izražen kao broj dana, iz prethodno izračunatog perioda treba dohvatiti i vratiti svojstvo Days (tj. svojstvo TimeSpan.Days).
            return period.Days;
        }

        // 007 Pokrenuti testove i provjeriti da svih 5 testova u grupi TestKorištenjaObjekta prolaze
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hr"); // en-US prikazuje drugi format

            IspišiTrenutniDatumVrijeme();

            IspišiDanašnjiDatum();

            IspišiTrenutnoVrijeme();

            Console.WriteLine(IzračunajBrojDanaIzmeđuDvaDatuma(2015, 5, 1, 2016, 5, 1));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

    }
}
