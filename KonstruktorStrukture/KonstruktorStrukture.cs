using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            Udaljenost u = new Udaljenost();
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);
        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost u = new Udaljenost(broj, jedinica);
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
