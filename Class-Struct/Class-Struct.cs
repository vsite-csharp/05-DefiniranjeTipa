using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    struct MojaStruktura
    {

        public string tekst;
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }

        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
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
            // TODO:026 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            Console.WriteLine();
            // TODO:027 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // TODO:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            mk1.IspišiČlan();
            mk2.IspišiČlan();
        }

        // TODO:029 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestClass_Struct.

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
