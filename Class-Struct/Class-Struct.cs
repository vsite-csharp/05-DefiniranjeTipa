using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    struct MojaStruktura
    {
        public String text;
        public MojaStruktura(String text)
        {
            this.text = text;
        }

        public void IspišiČlan()
        {
            Console.WriteLine(text);
        }
    }

    class MojaKlasa
    {
        public int broj = 5; // private je inace po defaultu

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }

    class ClassStruct
    {
        public static void IspišiStrukture()
        {
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            Console.WriteLine();

            Console.WriteLine();
            ms2.text = "MyStruct";
            ms1.IspišiČlan();
            ms2.IspišiČlan();
        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            mk1.IspišiČlan();
            mk2.IspišiČlan();

            Console.WriteLine();
            mk2.broj = 2;
            mk1.IspišiČlan();
            mk2.IspišiČlan();
        }

        static void Main(string[] args)
        {
            IspišiStrukture();
            Console.WriteLine();

            IspišiKlase();
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
