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
            IzvedenaIzJavneBazne izvedenaIzJavne = new IzvedenaIzJavneBazne();
            // TODO:031 Otkomentirajte donju naredbu, prevedite kod i provjerite radi li poziv ispravno.
            izvedenaIzJavne.IspišiMe();
        }

        public static void IspišiIzvedenuIzBazne()
        {
            IzvedenaIzBazne izvedenaIzBazne = new IzvedenaIzBazne();
            izvedenaIzBazne.IspišiMe();
        }

        public static void IspišiIzvedenuIzInterneBazne()
        {
            IzvedenaIzInterneBazne izvedenaIzInterne = new IzvedenaIzInterneBazne();
            izvedenaIzInterne.IspišiMe();
        }
    }
}
