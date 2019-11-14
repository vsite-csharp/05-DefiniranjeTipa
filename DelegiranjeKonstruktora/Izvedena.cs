using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Izvedena : Bazna
    {
        public readonly int B;

        public Izvedena(int a,int b) : base (a)
        {
            B = b;
            Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }


        public Izvedena(int a) : this(a,0)  //konstr koji poziva konstr
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));
        }
       
    }
}
