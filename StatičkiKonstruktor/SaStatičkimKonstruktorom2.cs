namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        public SaStatičkimKonstruktorom2 ()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.KonstruktorKlase");
        }
        // :094 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.KonstruktorKlase"

        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");
        }
        // :095 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.StatičkiKonstruktor"

        // :096 Ponovno pokrenuti program i pogledati ispis
        // prvo se poziva statički konstruktor klase, pa onda konstruktor bazne klase, pa zatim metoda izvedene klase

        // :097 Pokrenuti testove i provjeriti da oba testa u grupi TestStatičkogKonstruktora prolaze.
        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
