using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        public SaStatičkimKonstruktorom2()
        {
            Console.Write("SaStatičkimKonstruktorom1.StatičkiKonstruktor");
        }
        static SaStatičkimKonstruktorom2()
        {
            Console.Write("SaStatičkimKonstruktorom1.StatičkiKonstruktor");
        }

        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
