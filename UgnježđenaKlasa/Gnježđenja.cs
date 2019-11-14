using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Gnijezdo
    {
        internal class Ugnježđena
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
            Ugnježđena ug = new Ugnježđena();
            ug.IspišiMe();
        }
    }

    class IzvedenoGnijezdo : Gnijezdo
    {
        public void PredstaviSe()
        {
            Ugnježđena ug2 = new Ugnježđena();
            ug2.IspišiMe();
            ug2.PredstaviSe();
            ug2.PredstaviSeNeposredno();
        }
    }
}
