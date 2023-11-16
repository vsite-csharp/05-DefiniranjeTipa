namespace Vsite.CSharp.DefiniranjeTipa
{
    // DID_IT:020 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public.
    struct MojaStruktura
    {
        public string tekst = "MojaStruktura";

        public MojaStruktura() { }

        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }

    // DID_IT:025 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public.
    class MojaKlasa
    {
        public int broj = 5;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }

    }

    static class ClassStruct
    {
        public static void IspišiStrukture()
        {
            // DID_IT:021 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura".
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            ms2.tekst = "MojaStruktura";
            // DID_IT:022 Pozvati metodu IspišiČlan za obje instance (ms1 i ms2).
            ms1.IspišiČlan();
            ms2.IspišiČlan();

            Console.WriteLine();
            // DID_IT:023 Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            // DID_IT:024 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            ms1.IspišiČlan();
            ms2.IspišiČlan();

        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // DID_IT:026 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            mk1.IspišiČlan();
            mk2.IspišiČlan();

            Console.WriteLine();
            // DID_IT:027 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // DID_IT:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            mk2.IspišiČlan();
            mk1.IspišiČlan();
            

        }

        // DID_IT:029 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestClass_Struct.

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
