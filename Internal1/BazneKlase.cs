using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    public class JavnaBazna
    {
        public void IspišiMe()
        {
            Console.WriteLine("JavnaBazna");
        }
    }

    public class Bazna // default is internal
    {
        public void IspišiMe()
        {
            Console.WriteLine("???Bazna");
        }
    }
}
