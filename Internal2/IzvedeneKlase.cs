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
            InternaBazna bridge = new InternaBazna();
            bridge.IspišiMe();
        }
    }
}
