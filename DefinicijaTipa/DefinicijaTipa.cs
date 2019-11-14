using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        private int broj = 5;

        public void ispisiClan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        public MojaStruktura(string text)
        {
            this.text = text;
        }
        private string text;

        public void ispisiClan()
        {
            Console.WriteLine(text);
        }

    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa mk = new MojaKlasa();
            mk.ispisiClan();

        }

        public static void IspišiČlanStrukture()
        {
            var ms = new MojaStruktura("MojaStruktura");
            ms.ispisiClan();
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
