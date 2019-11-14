using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
    

        private int broj = 5;
       
        public void IspisiClan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }
        private string tekst;
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }

    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // TODO:012 Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan

        }

        public static void IspišiČlanStrukture()
        {
            // TODO:015 Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            MojaKlasa mk = new MojaKlasa(); 
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
