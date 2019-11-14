using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // TODO:070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            Udaljenost u;
            //Console.WriteLine(u.Broj);
            //Console.WriteLine(u.Jedinica);
            // TODO:072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
            Udaljenost u1 = new Udaljenost();
            Console.WriteLine(u1.Broj);
            Console.WriteLine(u1.Jedinica);



        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost u = new Udaljenost(broj,jedinica);
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {

            Udaljenost u = new Udaljenost(broj);
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);
        }

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
