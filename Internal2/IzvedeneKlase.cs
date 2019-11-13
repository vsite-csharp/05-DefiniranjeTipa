using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
     class IzvedenaIzJavneBazne:JavnaBazna
    {
       
    }

    class IzvedenaIzBazne: Bazna
    {
        
    }

     internal class InternaBazna
    {
        public void IspišiMe()
        {
            Console.WriteLine("InternaBazna");
        }
    }
    //IzvedenaIzInterneBazneLokalne

    class IzvedenaIzInterneBazne:InternaBazna
    {

        public void IspišiMe()
          {
            Console.WriteLine("InternaBazna");
        }
    }
}
