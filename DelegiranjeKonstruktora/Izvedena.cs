using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Izvedena : Bazna
    {
        public readonly int B;

        // Dodati konstruktor s dva argumenta ("a" i "b") tipa int, kojima će se inicijalizirati članovi A i B. Konstruktor treba pozivati konstruktor bazne klase s jednim argumentom i proslijediti mu argument a.
        // U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        public Izvedena(int a, int b) : base(a) 
        {
            B = b;
            Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }
        // Dodati konstruktor s jednim argumentom "a" tipa int. Taj konstruktor treba pozvati ("delegirati") prethodno definirani konstruktor klase Izvedena s dva argumenta s time da je prvi argument "a", a drugi argument je 0. 
        // U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));
        public Izvedena(int a) : this(a, 0)
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));
        }
    }
}
