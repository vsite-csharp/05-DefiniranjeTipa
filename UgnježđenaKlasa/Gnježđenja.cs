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
        // TODO:041 Napisati implementaciju metode PredstaviSe koja će pozvati najdostupniju metodu iz klase Ugnježđena
        // (po potrebi promijeniti pravo pristupa za klasu Ugnježđena)
        public void PredstaviSe()
        {
            Ugnježđena ug = new Ugnježđena();
            ug.PredstaviSe();
        }
    }
}
