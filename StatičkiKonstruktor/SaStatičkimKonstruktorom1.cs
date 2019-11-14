using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom1
    {
        //  Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.KonstruktorKlase"
        public SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonsturktorom1.KonstruktorKlase");
        }
        //  Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonsturktorom1.StatičkiKonstruktor");
        }
        //  Pokrenuti program i pogledati ispis

        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }
}
