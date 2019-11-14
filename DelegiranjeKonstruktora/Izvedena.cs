﻿namespace Vsite.CSharp.DefiniranjeTipa
{
    class Izvedena : Bazna
    {
        public readonly int B;

        public Izvedena(int a, int b) : base(a) {
            B = b;
            System.Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }
        public Izvedena(int a) : this(a, 0)
        {
            System.Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));
        }

        // TODO:085 U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));

    }
}
