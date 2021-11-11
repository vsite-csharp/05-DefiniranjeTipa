using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // :070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            Udaljenost u = new Udaljenost();
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);

            // :072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
            Udaljenost u2 = new Udaljenost();
            Console.WriteLine(u2.Broj);
            Console.WriteLine(u2.Jedinica);

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // :074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            //Udaljenost u3 = new Udaljenost(42, JedinicaDuljine.Kilometar);
            //Console.WriteLine(u3.Broj);
            //Console.WriteLine(u3.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // :076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.
            Udaljenost u4 = new Udaljenost(30);
            Console.WriteLine(u4.Broj);
            Console.WriteLine(u4.Jedinica);
        }

        // :077 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestKonstruktoraStrukture

        static void Main(string[] args)
        {

            PozivPodrazumijevanogKonstruktora();

            PozivKonstruktoraSDvaArgumenta(5, JedinicaDuljine.Kilometar);

            PozivKonstruktoraSJednimArgumentom(17);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
