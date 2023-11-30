namespace Vsite.CSharp.DefiniranjeTipa
{

    // :020 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public.
    struct MojaStruktura
    {
        public string tekst = "MojaStruktura";
        public MojaStruktura(string tekst) 
        {
            this.tekst = tekst;
        }
        public void IspišiČlan()
        {
            Console.WriteLine(this.tekst);
        }
    }


    // :025 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public.

    class MojaKlasa
    {
        public int broj = 5;
        public void IspišiČlan()
        {
            Console.WriteLine(this.broj);
        }
    }

    static class ClassStruct
    {
        public static void IspišiStrukture()
        {

            // :021 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura".
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");

            MojaStruktura ms2 = ms1;
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            // :022 Pozvati metodu IspišiČlan za obje instance (ms1 i ms2).

            Console.WriteLine();

            // :023 Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            // :024 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.

        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;

            mk1.IspišiČlan();
            mk2.IspišiČlan();
            // :026 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.

            Console.WriteLine();
            // :027 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // :028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            // klase su referentni tip -> kopira se adresa u memoriji članova bazne klase koja se kopira. -> obje vrijednosti su promjenjene
        }



        static void Main(string[] args)
        {
            IspišiStrukture();
            Console.WriteLine();

            IspišiKlase();
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
