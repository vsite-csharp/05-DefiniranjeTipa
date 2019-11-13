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
            
            JavnaBazna izvedenaIzJavne = new IzvedenaIzJavneBazne();

            
             izvedenaIzJavne.IspišiMe();
        }

        public static void IspišiIzvedenuIzBazne()
        {
           
           
            Bazna izvedenaIzBazne = new IzvedenaIzBazne();
           
            izvedenaIzBazne.IspišiMe();
        }

        public static void IspišiIzvedenuIzInterneBazne()
        {
            
            
            InternaBazna izvedenaIzInterne = new IzvedenaIzInterneBazne();
            izvedenaIzInterne.IspišiMe();
        }
    }
}
