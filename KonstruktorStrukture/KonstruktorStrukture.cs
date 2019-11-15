using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            
            Udaljenost ud = new Udaljenost();
            Console.WriteLine(ud.Broj);
            Console.WriteLine(ud.Jedinica);

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost ud2 = new Udaljenost(broj, jedinica);
            Console.WriteLine(ud2.Broj);
            Console.WriteLine(ud2.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost ud1 = new Udaljenost(broj);
            Console.WriteLine(ud1.Broj);
            Console.WriteLine(ud1.Jedinica);

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
