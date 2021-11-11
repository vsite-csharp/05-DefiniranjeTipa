using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class IzvedenaIzJavneBazne  : JavnaBazna
    {
    }

    class IzvedenaIzBazne  : Bazna
    {
    }



    internal class InternaBazna
    {
        public void IspišiMe()
        {
            Console.WriteLine("InternaBazna");
        }
    }

    public class IzvedenaIzInterneBazne //: InternaBazna  // Bazna je internal i želimo izvedenu koja je public, to ne može
    {
        public void IspišiMe()
        {
            var inter = new InternaBazna();
            inter.IspišiMe();
        }
    }
}
