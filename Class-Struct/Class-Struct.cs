using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    
    class MojaKlasa
    {

        public int broj = 5;

        public MojaKlasa(int broj)
        {
            this.broj = broj;

        }
        public int Broj
        {
            get { return broj; }
            set { this.broj = value; }

        }
        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }

    
    struct MojaStruktura
    {
        public string tekst;
        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }
        public string Tekst
        {
            get
            {
                return tekst;
            }


        }

        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }

    }

    class ClassStruct
    {
        public static void IspišiKlase()
        {
            int broj = 5;
            MojaKlasa mk1 = new MojaKlasa(broj);
            MojaKlasa mk2 = mk1;
            
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            //ISPIS: 5 5
            Console.WriteLine();
            
            mk2.broj = 2;
            
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            //ISPIS: 2 2
        }

        public static void IspišiStrukture()
        {
            
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
            
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            // ISPIS:         MojaStruktura
            //               MojaStruktura

            Console.WriteLine();
            
            ms2.tekst = "MyStruct";
            
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            //ISPIS:  MojaStruktura
           //          MyStruct

        }

        static void Main(string[] args)
        {
            IspišiKlase();

            Console.WriteLine();

            IspišiStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
