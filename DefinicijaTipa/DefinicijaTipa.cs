using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        private int broj = 5;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        private string tekst;
        
        public void IspišiČlan()
        {
            tekst = "MojaStruktura";
            Console.WriteLine(tekst);
        }
    }


    class DefinicijaTipa
    {
        

        public static void IspišiČlanKlase()
        {
            MojaKlasa klasa = new MojaKlasa();
            klasa.IspišiČlan();

        }

        public static void IspišiČlanStrukture()
        {

            MojaStruktura struktura = new MojaStruktura();
            struktura.IspišiČlan();
        }

        static void Main(string[] args)
        {
            
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
