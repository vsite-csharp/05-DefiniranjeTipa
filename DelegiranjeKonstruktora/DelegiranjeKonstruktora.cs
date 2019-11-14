using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class DelegiranjeKonstruktora
    {

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            // TODO:082 Stvoriti objekt pozivom tog konstruktora:
            // TODO:083 Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
            Izvedena i = new Izvedena(a, b);
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(int a)
        {
            // TODO:086 Stvoriti objekt pozivom tog konstruktora:
            // TODO:087 Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
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
