using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        //094 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.KonstruktorKlase"
        public SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.KonstruktorKlase");
        }
        // TODO:095 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");
        }
        //096 Ponovno pokrenuti program i pogledati ispis
        /*Ispis: SaStatickimKonstruktorom1.StatickiKonstruktor
        SaStatickimKonstruktorom1.Metoda1
        SaStatickimKonstruktorom2.StatickiKonstruktor
        SaStatickimKonstruktorom1.KonstruktorKlase
        SaStatickimKonstruktorom2.KonstruktorKlase
        SaStatickimKonstruktorom2.Metoda2
        GOTOVO!!!*/

        //097 Pokrenuti testove i provjeriti da oba testa u grupi TestStatičkogKonstruktora prolaze.
        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }
}
