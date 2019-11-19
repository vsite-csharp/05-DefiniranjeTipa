using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            Udaljenost dalj = new Udaljenost();
            Console.WriteLine(dalj.Broj);
            Console.WriteLine(dalj.Jedinica);

            Udaljenost dalj2 = new Udaljenost();
            Console.WriteLine(dalj2.Broj);
            Console.WriteLine(dalj2.Jedinica);

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost dalj = new Udaljenost(broj,jedinica);
            Console.WriteLine(dalj.Broj);
            Console.WriteLine(dalj.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost dalj = new Udaljenost(broj);
            Console.WriteLine(dalj.Broj);
            Console.WriteLine(dalj.Jedinica);
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
