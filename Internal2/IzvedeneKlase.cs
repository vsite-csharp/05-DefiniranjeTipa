using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class IzvedenaIzJavneBazne : JavnaBazna
    {
    }

    class IzvedenaIzBazne : Bazna
    {
    }

    internal class InternaBazna
    {
        public void IspišiMe()
        {
            Console.WriteLine("InternaBazna");
        }
    }

    public class IzvedenaIzInterneBazne
    {
        private InternaBazna internaBaza =  new InternaBazna();

        public void IspišiMe()
        {
            internaBaza.IspišiMe();
        }
    }
}
