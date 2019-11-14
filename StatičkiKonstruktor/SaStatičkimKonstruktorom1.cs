using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class SaStatičkimKonstruktorom1
    {
        // TODO:090 Dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.KonstruktorKlase"
       public SaStatičkimKonstruktorom1() {

            Console.WriteLine("SaStatičkimKonstruktorom1.KonstruktorKlase");
            /*1.se pozivaSaStatickimKonstruktorom1.StatickiKonstruktor
SaStatickimKonstruktorom1.Metoda1*/
        }
        // TODO:091 Dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom1.StatičkiKonstruktor"
        static SaStatičkimKonstruktorom1()
        {

            Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");

        }
        // TODO:092 Pokrenuti program i pogledati ispis
        /*SaStatickimKonstruktorom1.Metoda1

SaStatickimKonstruktorom2.Metoda2
GOTOVO!!!
*/
        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }
}
