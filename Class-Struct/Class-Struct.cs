using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    struct MojaStruktura
    {
        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }
        public string tekst;

        public void ispisiClan()
        {
            Console.WriteLine(tekst);
        }


    }

    class MojaKlasa
    {
        public int broj = 5;

        public void ispisiClan()
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
            ms1.ispisiClan();
            ms2.ispisiClan();
            Console.WriteLine();

            ms2.tekst = "MyStruct";

            ms1.ispisiClan();
            ms2.ispisiClan();

        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            mk1.ispisiClan();
            mk2.ispisiClan();

            Console.WriteLine();
            mk2.broj = 2;
            mk1.ispisiClan();
            mk2.ispisiClan();
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
