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

        // TODO:040 Napisati implementaciju metode IspišiMe koja će pozvati metodu IspišiMe iz klase Ugnježđena
        public void IspišiMe()
        {
            Ugnježđena u = new Ugnježđena();
            u.IspišiMe();
        }
    }

    class IzvedenoGnijezdo : Gnijezdo
    {
        
        public void PredstaviSe()
        {
            Ugnježđena u = new Ugnježđena();
            u.PredstaviSe();
        }
    }
}
