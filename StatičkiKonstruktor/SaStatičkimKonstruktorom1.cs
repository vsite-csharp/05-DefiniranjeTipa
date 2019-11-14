using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom1
    {
        // TODO:090 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.KonstruktorKlase"
        // TODO:091 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.StatičkiKonstruktor"
        public SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.KonstruktorKlase");
        }
        static SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");
        }
        // TODO:092 Pokrenuti program i pogledati ispis

        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }
}
