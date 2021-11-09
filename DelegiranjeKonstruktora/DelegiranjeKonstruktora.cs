using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class DelegiranjeKonstruktora
    {

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            // TODO:082 Stvoriti objekt pozivom tog konstruktora:
            Izvedena i = new Izvedena(a, b);

            // TODO:083 Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(int a)
        {
            // TODO:086 Stvoriti objekt pozivom tog konstruktora:
            Izvedena i = new Izvedena(a);

            // TODO:087 Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        // TODO:088 Pokrenuti testove i provjeriti da oba testa u grupi TestDelegiranjaKonstruktora prolaze.
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
