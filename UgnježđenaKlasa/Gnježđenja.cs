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

        // TODO:040 Napisati implementaciju metode IspišiMe koja će pozvati metodu IspišiMe iz klase Ugnježđena
        public void IspišiMe()
        {
            var ug = new Gnijezdo.Ugnježđena();
            ug.IspišiMe();

        }
    }

    class IzvedenoGnijezdo : Gnijezdo
    {
        // TODO:041 Napisati implementaciju metode PredstaviSe koja će pozvati najdostupniju metodu iz klase Ugnježđena
        // (po potrebi promijeniti pravo pristupa za klasu Ugnježđena)
        public  void PredstaviSe()
        {
            Ugnježđena u = new Ugnježđena();
            u.PredstaviSe();
        }
    }
}
       
