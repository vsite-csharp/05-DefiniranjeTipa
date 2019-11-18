using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // TODO:070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.

            Udaljenost obj = new Udaljenost();
            // TODO:072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
            Console.WriteLine(obj.Broj);
            Console.WriteLine(obj.Jedinica);
        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // TODO:074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            Udaljenost obj2 = new Udaljenost(broj, jedinica);
            Console.WriteLine(obj2.Broj);
            Console.WriteLine(obj2.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // TODO:076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.
            Udaljenost obj3 = new Udaljenost(broj);
            Console.WriteLine(obj3.Broj);
            Console.WriteLine(obj3.Jedinica);
            
        }

        static void Main(string[] args)
        {

            PozivPodrazumijevanogKonstruktora();
            Console.WriteLine("------------");
            PozivKonstruktoraSDvaArgumenta(5, JedinicaDuljine.Kilometar);
            Console.WriteLine("------------");
            PozivKonstruktoraSJednimArgumentom(17);
            Console.WriteLine("------------");
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
