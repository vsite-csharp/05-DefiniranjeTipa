namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:020 Prekopirati kod strukture iz prethodnog primjera
    // TODO:021 Strukturi dodati javnu metodu PromijeniČlan tipa void i u njoj napisati naredbu kojom će se podatkovni član "tekst" promijeniti u vrijednost zadanu parametrom metode.
    struct MojaStruktura
    {


    }

    // TODO:025 Prekopirati kod klase iz prethodnog primjera.
    // TODO:026 Klasi dodati javnu metodu PromijeniČlan tipa void i u njoj napisati naredbu kojom će se podatkovni član "broj" promijeniti u vrijednost zadanu parametrom metode.
    class MojaKlasa
    {

    }

    static class ClassStruct
    {
        public static void IspišiStrukture()
        {
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            // TODO:022 Pozvati metodu IspišiČlan za obje instance (ms1 i ms2).

            Console.WriteLine();
            // TODO:023 Dodati poziv metode PromijeniČlan objekta ms2 i metodi proslijediti "MyStruct".

            // TODO:024 Ponovno pozvati metodu IspišiČlan za obje instance te provjeriti i obrazložiti ispise.

        }

        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // TODO:027 Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.

            Console.WriteLine();
            // TODO:028 Dodati poziv metode PromijeniČlan objekta mk2 i metodi proslijediti broj 2.

            // TODO:029 Ponovno pozvati metodu IspišiČlan za obje instance te provjeriti i obrazložiti ispise.

        }

        // TODO:029a Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestClass_Struct.

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
