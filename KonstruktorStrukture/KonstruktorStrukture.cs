using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            Udaljenost len = new Udaljenost();
            Console.WriteLine(len.Broj);
            Console.WriteLine(len.Jedinica);

            
            //Udaljenost len2 = new Udaljenost();

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost objekt = new Udaljenost(3.0, (JedinicaDuljine)4);
            Console.WriteLine(objekt.Broj);
            Console.WriteLine(objekt.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost objekt2 = new Udaljenost(3.0);
            Console.WriteLine(objekt2.Broj);
            Console.WriteLine(objekt2.Jedinica);

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
