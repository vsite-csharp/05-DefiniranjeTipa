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
            // Definiciju klase IzvedenaIzJavneBazne promijenite tako da je ona izvedena iz klase JavnaBazna.
            IzvedenaIzJavneBazne izvedenaIzJavne = new IzvedenaIzJavneBazne();
            
            // Otkomentirajte donju naredbu, prevedite kod i provjerite radi li poziv ispravno.
            izvedenaIzJavne.IspišiMe();
        }

        public static void IspišiIzvedenuIzBazne()
        {
            // Definiciju klase IzvedenaIzBazne promijenite tako da je ona izvedena iz klase Bazna. Prevedite kod i popravite pogreške koje prevoditelj prijavljuje.
            IzvedenaIzBazne izvedenaIzBazne = new IzvedenaIzBazne();
            
            // Otkomentirajte donju naredbu, prevedite kod i provjerite radi li poziv ispravno.
            izvedenaIzBazne.IspišiMe();
        }

        public static void IspišiIzvedenuIzInterneBazne()
        {
            // U klasi IzvedenaIzInterneBazne treba, bez promjene prava pristupa, omogućiti poziv metode IspišiMe iz klase InternaBazna ali bez promjene koda klase InternaBazna!
            IzvedenaIzInterneBazne izvedenaIzInterne = new IzvedenaIzInterneBazne();
            
            // Otkomentirati donju naredbu i provjeriti izvođenje.
            izvedenaIzInterne.IspišiMe();
        }

        // Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestInternal
    }
}
