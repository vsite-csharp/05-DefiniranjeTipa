using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        public SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.KonstruktorKlase");  //2.
        }
        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");  // 1.

        }

        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");   // 3.
        }
    }
}
