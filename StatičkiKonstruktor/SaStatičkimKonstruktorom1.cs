using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom1
    {
        //091 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.KonstruktorKlase"
        public SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.KonstruktorKlase");
        }
        //092 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");
        }
        // 093 Pokrenuti program i pogledati ispis
        // Ispis: SaStatickimKonstruktorom1.StatickiKonstruktor
        //        SaStatickimKonstruktorom1.Metoda1

        //SaStatickimKonstruktorom1.KonstruktorKlase
        //SaStatickimKonstruktorom2.Metoda2
        //GOTOVO!!!
        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }
}
