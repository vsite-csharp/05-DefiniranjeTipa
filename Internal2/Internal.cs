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
            izvedenaIzJavne.IspišiMe();
        }

        public static void IspišiIzvedenuIzBazne()
        {
            IzvedenaIzBazne izvedenaIzBazne = new IzvedenaIzBazne();
            izvedenaIzBazne.IspišiMe();
        }

        public static void IspišiIzvedenuIzInterneBazne()
        {
            // TODO:034 U klasi IzvedenaIzInterneBazneLokalne treba, bez promjene prava pristupa, omogućiti poziv metode IspišiMe iz klase InternaBazna ali bez promjene koda klase InternaBazna!
            IzvedenaIzInterneBazne izvedenaIzInterne = new IzvedenaIzInterneBazne();
            izvedenaIzInterne.IspišiMe();
        }
    }
}
