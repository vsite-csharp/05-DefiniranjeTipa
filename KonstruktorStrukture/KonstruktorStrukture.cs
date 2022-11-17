using System;
using System.Security.Cryptography.X509Certificates;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // :070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            var udaljenost = new Udaljenost();
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);


            // :072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.


        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // TODO:074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            PublicKey Udaljenost(double broj)
            {
                Broj = broj;
                Jedinica = JedinicaDuljine.Metar;
            }

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // TODO:076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.

        }

        // TODO:077 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestKonstruktoraStrukture

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
