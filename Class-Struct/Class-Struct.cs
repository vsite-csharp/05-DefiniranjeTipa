using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public
    class MojaKlasa
    {
        public int broj = 5;
        internal void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }


    // TODO:024 Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
    struct MojaStruktura
    {
        public string tekst;
        internal MojaStruktura(string tekst) => this.tekst = tekst;
        internal void IspišiČlan()
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
            // TODO:021 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            mk1.IspišiČlan();
            mk2.IspišiČlan();

            Console.WriteLine();
            // TODO:022 Otkomentirati donju naredbu.
            mk2.broj = 2;
            // TODO:023 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            // mk2 pokazuje na isti objekt, to nije kopija mk1 objekta
        }

        public static void IspišiStrukture()
        {
            // TODO:025 Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura"
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
            // TODO:026 Pozvati metodu IspišiČlan za obje instance
            ms1.IspišiČlan();
            ms2.IspišiČlan();

            Console.WriteLine();
            // TODO:027 Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            // TODO:028 Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            // ms2 je zasebna kopija ms1 objekta - promjena je izvršena samo na kopiji
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

