﻿namespace Vsite.CSharp.DefiniranjeTipa
{
    static class DelegiranjeKonstruktora
    {

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            // 082 Stvoriti objekt pozivom tog konstruktora:
            Izvedena i = new Izvedena(a, b);
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
            // 083 Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(int a)
        {
            // 086 Stvoriti objekt pozivom tog konstruktora:
            Izvedena i = new Izvedena(a);
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
            // 087 Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
        }

        // 088 Pokrenuti testove i provjeriti da oba testa u grupi TestDelegiranjaKonstruktora prolaze.
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
