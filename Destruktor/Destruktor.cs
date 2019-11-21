using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Destruktor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

           
            for(int br = 0; br < 10000; br++)//smanjio za jednu 0
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }
            /*....
             * Destruktor objekta br. 9291
                Destruktor objekta br. 9290
                 Zavrsio sam 'Main'
                Destruktor objekta br. 10001
                Destruktor objekta br. 9289
                Destruktor objekta br. 9288
                Destruktor objekta br. 1*/
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
