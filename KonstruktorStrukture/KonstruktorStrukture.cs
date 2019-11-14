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

            Udaljenost ud = new Udaljenost();
            Console.WriteLine(ud.Broj);
            Console.WriteLine(ud.Jedinica);

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost uda = new Udaljenost(23, JedinicaDuljine.Centimetar);
            Console.WriteLine(uda.Broj);
            Console.WriteLine(uda.Jedinica);
        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost uda2 = new Udaljenost(32);
            Console.WriteLine(uda2.Broj);
            Console.WriteLine(uda2.Jedinica);
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
