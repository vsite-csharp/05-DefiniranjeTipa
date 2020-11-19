using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            //  Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            var d = new Udaljenost();
            Console.WriteLine(d.Broj);
            Console.WriteLine(d.Jedinica);
            //  Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
             d = new Udaljenost();
            Console.WriteLine(d.Broj);
            Console.WriteLine(d.Jedinica);

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            //  Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            var d = new Udaljenost(broj, jedinica);
            Console.WriteLine(d.Broj);
            Console.WriteLine(d.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            //  Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.
            var d = new Udaljenost(broj);
            Console.WriteLine(d.Broj);
            Console.WriteLine(d.Jedinica);
        }

        //  Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestKonstruktoraStrukture

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
