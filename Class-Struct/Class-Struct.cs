namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public.
    struct MojaStruktura
    {
        public string tekst = "MojaStruktura";
        public MojaStruktura() { }
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }

    // TODO:025 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public.
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
            // DONE:021 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura".
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            ms1.tekst = "MojaStruktura";
            // DONE:022 Pozvati metodu IspišiČlan za obje instance (ms1 i ms2).
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            Console.WriteLine();
            // DONE:023 Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            // DONE:024 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            //struktura je vrijednosni tip podatka što znači ako promijenimo vrijednost jednom objektu neće se promijenit 
            //drugi nego će se kreirati kopija tog objekta na drugoj adresi

        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // DONE:026 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            Console.WriteLine();
            // DONE:027 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // DONE:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            mk1.IspišiČlan();
            mk2.IspišiČlan();
        }

        // DONE:029 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestClass_Struct.

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
