using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class UgnježđenaKlasa
    {
        static void Main(string[] args)
        {
            Gnijezdo g = new Gnijezdo();
            g.IspišiMe();

            IzvedenoGnijezdo ig = new IzvedenoGnijezdo();
            ig.PredstaviSe();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static void IzravnoKorištenjeUgnježđeneKlase()
        {
            
            Gnijezdo.Ugnježđena gu = new Gnijezdo.Ugnježđena();   //morali smo promijeniti u Gnježđenje public ili internal
            gu.PredstaviSeNeposredno();
        }
    }
}
