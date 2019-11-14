using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        private int broj = 5; // private je inace po defaultu

        public void IspišiČlan() {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        private String text;
        public MojaStruktura(String text) {
            this.text = text;
        }

        public void IspišiČlan()
        {
            Console.WriteLine(text);
        }
    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa mk = new MojaKlasa();
            mk.IspišiČlan();
        }

        public static void IspišiČlanStrukture()
        {
            var ms = new MojaStruktura("MojaStruktura");
            ms.IspišiČlan();
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
