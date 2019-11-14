using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        public SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.KonstruktorKlase");
        }
        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");
        }
        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }

        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
