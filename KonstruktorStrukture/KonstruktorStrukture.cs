using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            Udaljenost d = new Udaljenost();
            Console.WriteLine(d.Broj);
            Console.WriteLine(d.Jedinica);

           




        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost dist = new Udaljenost(broj, jedinica);
            Console.WriteLine(dist.Broj);
            Console.WriteLine(dist.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost dist = new Udaljenost(broj);
            Console.WriteLine(dist.Broj);
            Console.WriteLine(dist.Jedinica);
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
