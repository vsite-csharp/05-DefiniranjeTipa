using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Izvedena  : Bazna
    {
        public readonly int B;
        public Izvedena(int a,int b):base(a)
        {
            B = b;
            Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }

        public Izvedena(int a) : this(a,0)
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));
        }
        // TODO:084 Dodati konstruktor s jednim argumentom "a" tipa int. Taj konstruktor treba pozvati ("delegirati") prethodno definirani konstruktor klase Izvedena s dva argumenta s time da je prvi argument "a", a drugi argument je 0. 
        // TODO:085 U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));

    }
}
