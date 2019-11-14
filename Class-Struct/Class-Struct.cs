using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
    struct MojaStruktura
    {
       
            public MojaStruktura(string tekst)
            {
                this.tekst = tekst;
            }
            public string tekst;


            public void IspišiČlan()
            {
                Console.WriteLine(tekst);
            }
       

    }

    class MojaKlasa
    {
        public int broj = 5;


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
           
            ms2.tekst = "MyStruct";
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
