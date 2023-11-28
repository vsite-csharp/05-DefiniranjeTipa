namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        // DONE:094 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.KonstruktorKlase"
        public SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.KonstruktorKlase");
        }

        // DONE:095 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");
        }
        // DONE:096 Ponovno pokrenuti program i pogledati ispis

        // DONE:097 Pokrenuti testove i provjeriti da oba testa u grupi TestStatičkogKonstruktora prolaze.
        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
