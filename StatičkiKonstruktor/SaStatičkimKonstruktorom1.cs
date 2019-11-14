using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom1
    {
        // TODO:091 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.KonstruktorKlase"
        public SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.KonstruktorKlas");
        }
        // TODO:092 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom1() //STATICKI KONSTRUKTOR NE MOZE PRIMATI ARGUMENTE I NE MOZE BITI PUBLIC
        {
            // STATICKI KONSTUKTOR SE OKIDA NA KREIRANJE PRVOG OBJEKTA ILI NA POZIV BILO KOJE METODE KLASE ILI VARIJABLE
            Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");

        }
        // TODO:093 Pokrenuti program i pogledati ispis

        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }
}
