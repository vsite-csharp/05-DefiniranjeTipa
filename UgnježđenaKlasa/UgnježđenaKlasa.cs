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
            // TODO:042 Modificirati definicije tako da se klasa Ugnježđena može pozivati izravno:
            //Gnijezdo.Ugnježđena gu = new Gnijezdo.Ugnježđena();
            //gu.PredstaviSeNeposredno();
        }

        // TODO:043 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestUgnježđena.
    }
}
