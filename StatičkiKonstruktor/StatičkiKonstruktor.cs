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

        // :090 Pokrenuti program, pogledati ispis i obrazložiti ga.

        // Kod pozivanja statičke metode automatski se poziva staticki instruktor.
        // Kako bi pozvali nestatičku metodu potrebna nam je instanca klase, što znači da se prvo mora pozvati statički konstruktor, zatim konstruktori
        // bazne i izvedene klase i tek nakon toga se poziva metoda klase.

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
