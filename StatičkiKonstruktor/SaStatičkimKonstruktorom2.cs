using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        public SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonsturktorom2.KonstruktorKlase");
        }
        //  Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonsturktorom2.StatičkiKonstruktor");
        }
        //  Pokrenuti program i pogledati ispis

        // TODO:094 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.KonstruktorKlase"

        // TODO:095 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.StatičkiKonstruktor"

        // TODO:096 Ponovno pokrenuti program i pogledati ispis

        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
