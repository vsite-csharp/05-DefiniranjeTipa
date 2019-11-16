using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {

            Udaljenost distanceTwo = new Udaljenost();
            Console.WriteLine(distanceTwo.Broj);
            Console.WriteLine(distanceTwo.Jedinica);
        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost distance = new Udaljenost(broj, jedinica);
            Console.WriteLine(distance.Broj);
            Console.WriteLine(distance.Jedinica);
        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost distance = new Udaljenost(broj);
            Console.WriteLine(distance.Broj);
            Console.WriteLine(distance.Jedinica);
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
