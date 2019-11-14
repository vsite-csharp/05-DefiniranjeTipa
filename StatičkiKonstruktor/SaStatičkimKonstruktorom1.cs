using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom1
    {
        public SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.KonstruktorKlase");  //zadnji
        }
        static SaStatičkimKonstruktorom1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");  //prvi

        }


        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");  //drugi
        }
    }
}
