using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    struct MojaStruktura
    {
        public string tekst;
        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }



        public void IspisiClan()
        {
            Console.WriteLine(this.tekst);
        }

    }

    class MojaKlasa
    {
        public int broj;
        public MojaKlasa(int broj)
        {
            this.broj = broj;
        }


        public void IspisiClan()
        {
            Console.WriteLine(this.broj);
        }
    }

    class ClassStruct
    {
        public static void IspišiStrukture()
        {
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
            ms1.IspisiClan();
            ms2.IspisiClan();
            Console.WriteLine();
            ms2.tekst = "MyStruct";
            ms1.IspisiClan();
            ms2.IspisiClan();
        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa(5);
            MojaKlasa mk2 = mk1;
            mk1.IspisiClan();
            mk2.IspisiClan();
            Console.WriteLine();
            mk2.broj = 2;
            mk1.IspisiClan();
            mk2.IspisiClan();
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
