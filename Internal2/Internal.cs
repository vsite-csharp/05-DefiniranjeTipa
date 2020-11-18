using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Internal
    {
        static void Main(string[] args)
        {
            IspišiIzvedenuIzJavne();

            IspišiIzvedenuIzBazne();

            IspišiIzvedenuIzInterneBazne();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static void IspišiIzvedenuIzJavne()
        {
            // TODO:030 Definiciju klase IzvedenaIzJavneBazne promijenite tako da je ona izvedena iz klase JavnaBazna.
            IzvedenaIzJavneBazne izvedenaIzJavne = new IzvedenaIzJavneBazne();
            // TODO:031 Otkomentirajte donju naredbu, prevedite kod i provjerite radi li poziv ispravno.
            //izvedenaIzJavne.IspišiMe();
        }

        public static void IspišiIzvedenuIzBazne()
        {
            // TODO:032 Definiciju klase IzvedenaIzBazne promijenite tako da je ona izvedena iz klase Bazna. Prevedite kod i popravite pogreške koje prevoditelj prijavljuje.
            // TODO:033 Promijenite pravo pristupa klasi Bazna da se kod može prevesti.
            IzvedenaIzBazne izvedenaIzBazne = new IzvedenaIzBazne();
            // TODO:034 Otkomentirajte donju naredbu, prevedite kod i provjerite radi li poziv ispravno.
            //izvedenaIzBazne.IspišiMe();
        }

        public static void IspišiIzvedenuIzInterneBazne()
        {
            // TODO:035 U klasi IzvedenaIzInterneBazne treba, bez promjene prava pristupa, omogućiti poziv metode IspišiMe iz klase InternaBazna ali bez promjene koda klase InternaBazna!
            IzvedenaIzInterneBazne izvedenaIzInterne = new IzvedenaIzInterneBazne();
            // TODO:036 Otkomentirati donju naredbu i provjeriti izvođenje.
            //izvedenaIzInterne.IspišiMe();
        }

        // TODO:037 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestInternal
    }
}
