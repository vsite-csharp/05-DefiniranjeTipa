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
        // Poziva se statički konstruktor, koji poziva statičku metodu. Primjer je npr. Math.Sin() ili slična klasa koju ne inicijaliziramo, već samo metode pozivamo

        static void Main(string[] args)
        {
            PozoviSamoStatičkuMetodu();
            Console.WriteLine();
            PozoviNestatičkuMetodu();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
