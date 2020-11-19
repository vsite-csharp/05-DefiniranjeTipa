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

            protected void PredstaviSe()
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
            var uk = new Ugnježđena();
            uk.IspišiMe();
        }
    }

    class IzvedenoGnijezdo : Gnijezdo
    {
        public void PredstaviSe()
        {
            var uk = new Ugnježđena();
            uk.PredstaviSeNeposredno();
        }
    }
}
