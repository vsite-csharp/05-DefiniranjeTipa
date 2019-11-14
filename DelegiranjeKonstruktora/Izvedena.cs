using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Izvedena  : Bazna
    {
        public readonly int B;

        public Izvedena (int a,int b) : base(a)//80
        {
            B = b;
            Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }

        public Izvedena(int a): this(a, 0)//84
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));
        }
       

    }
}
