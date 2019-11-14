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
            Ugnježđena u = new Ugnježđena();
            u.IspišiMe();
        }
    }

    class IzvedenoGnijezdo : Gnijezdo
    {
        // (po potrebi promijeniti pravo pristupa za klasu Ugnježđena) promjenili smo ju u protected da možemo dobiti pristup
        public void PredstaviSe()
        {
            Ugnježđena u = new Ugnježđena();
            u.PredstaviSe();
        }
    }
}
