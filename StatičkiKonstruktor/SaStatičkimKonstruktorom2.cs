using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        // Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.KonstruktorKlase"
        public SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.KonstruktorKlase");
        }

        // Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");
        }
        // Ponovno pokrenuti program i pogledati ispis

        // Pokrenuti testove i provjeriti da oba testa u grupi TestStatičkogKonstruktora prolaze.
        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
