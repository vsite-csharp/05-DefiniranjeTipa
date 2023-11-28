namespace Vsite.CSharp.DefiniranjeTipa
{
    static class StatičkiKonstruktor
    {
        public static void PozoviSamoStatičkuMetodu()
        {
            SaStatičkimKonstruktorom1.Metoda1();
        }

        public static void PozoviNestatičkuMetodu()
        {
            SaStatičkimKonstruktorom2 sk = new SaStatičkimKonstruktorom2();
            sk.Metoda2();
        }

        // DONE:090 Pokrenuti program, pogledati ispis i obrazložiti ga.
        // u prvom se ispiše statički konstruktor koji se ispisuje uvijek pozivom bilo koje metode klase, a u drugom
        // se ispiše i konstruktor klase i bazne i naslijeđene plus statički budući da smo ovdje kreirali objekt tipa te klase

        static void Main(string[] args)
        {
            PozoviSamoStatičkuMetodu();
            Console.WriteLine();
            PozoviNestatičkuMetodu();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
