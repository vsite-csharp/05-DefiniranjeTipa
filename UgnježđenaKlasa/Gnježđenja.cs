using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Gnijezdo
    {
        public class Ugnježđena
        {
            public void IspišiMe()
            {
                Console.WriteLine("Ugnježđena");
            }

            public void PredstaviSe()
            {
                Console.WriteLine("Ja sam klasa Ugnježđena");
            }

            public void PredstaviSeNeposredno()
            {
                Console.WriteLine("Ja sam klasa Ugnježđena, neposredno");
            }
        }

        public void IspišiMe()
        {
            Ugnježđena objekt = new Ugnježđena();
            objekt.IspišiMe();
        }
    }


    class IzvedenoGnijezdo : Gnijezdo
    {
        public void PredstaviSe()
        {
            
            Gnijezdo.Ugnježđena objekt = new Gnijezdo.Ugnježđena();
            objekt.PredstaviSe();
        }
    }
}
