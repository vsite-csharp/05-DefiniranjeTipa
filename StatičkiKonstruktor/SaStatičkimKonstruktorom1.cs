namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom1
    {
        // DONE:091 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.KonstruktorKlase"
        public SaStatičkimKonstruktorom1 ()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.KonstruktorKlase");
        }
        // DONE:092 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");
        }
        // DONE:093 Pokrenuti program i pogledati ispis

        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }
}
