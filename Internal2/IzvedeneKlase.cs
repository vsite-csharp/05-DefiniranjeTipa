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

    class IzvedenaIzInterneBazne
    {

        public void IspišiMe()
        {
            InternaBazna int_baz = new InternaBazna();
            int_baz.IspišiMe();
        }
    }
}
