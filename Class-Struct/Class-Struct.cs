using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        public int broj = 5;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
     
    }

    struct MojaStruktura
    {
        public string tekst;
    
        public void IspišiČlan()
        {
            tekst = "MojaStruktura";
            Console.WriteLine(tekst);
        }
        public void IspišiČlan(string tekst)
        {
            Console.WriteLine(tekst);
        }

    }

    class ClassStruct
    {
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
            //mk1 i mk2 imaju pokazuju na istu vrijednost ako promjenimo vrijednost jednom promjenimo vrijednost na oba

        }

        public static void IspišiStrukture()
        {
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            ms1.IspišiČlan();
            ms2.IspišiČlan();

            Console.WriteLine();
            ms2.tekst = "MyStruct";
            //pozivom metoda overridamo upisano tj. MyStruct postaje Moja struktura, pa dodajemo novu metodu sa argumentom
            ms1.IspišiČlan(ms1.tekst);
            ms2.IspišiČlan(ms2.tekst);
            

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
