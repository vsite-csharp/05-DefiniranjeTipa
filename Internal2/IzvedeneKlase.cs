using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class IzvedenaIzJavneBazne  : InternaBazna
    {
    }

    class IzvedenaIzBazne : IzvedenaIzInterneBazne
    {
    }



    internal class InternaBazna
    {
        public void IspišiMe()
        {
            Console.WriteLine("InternaBazna");
        }
    }

    class IzvedenaIzInterneBazne
    {

        public void IspišiMe()
        {
        }
    }
}
