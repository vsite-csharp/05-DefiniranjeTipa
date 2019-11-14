using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class DelegiranjeKonstruktora
    {

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            
            Izvedena i = new Izvedena(a, b);
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(int a)
        {
             Izvedena i = new Izvedena(a);
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        static void Main(string[] args)
        {
            StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);
            Console.WriteLine();
            StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(5);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
