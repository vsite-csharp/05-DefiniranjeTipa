using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Gnijezdo
    {
        class Ugnježđena
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
            Ugnježđena objekt = new Ugnježđena();
            objekt.IspišiMe();
        }
    }


    class IzvedenoGnijezdo : Gnijezdo
    {
        // TODO:041 Napisati implementaciju metode PredstaviSe koja će pozvati metodu PredstaviSe iz klase Ugnježđena
        public void PredstaviSe()
        {
            IzvedenoGnijezdo ig = new IzvedenoGnijezdo();
            ig.PredstaviSe();
        }
    }
}
