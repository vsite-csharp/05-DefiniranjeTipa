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
        public void IspišiMe() 
        {
            var ib = new InternaBazna();
            ib.IspišiMe();
        }
    }
}
