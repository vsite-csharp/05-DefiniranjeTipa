using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            Udaljenost u1 = new Udaljenost();

            Console.WriteLine(u1.Broj);
            Console.WriteLine(u1.Jedinica);

            Udaljenost u2 = new Udaljenost();

            Console.WriteLine(u2.Broj);
            Console.WriteLine(u2.Jedinica);
        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost u3 = new Udaljenost(broj,jedinica);

            Console.WriteLine(u3.Broj);
            Console.WriteLine(u3.Jedinica);
        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost u4 = new Udaljenost(broj);

            Console.WriteLine(u4.Broj);
            Console.WriteLine(u4.Jedinica);
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
