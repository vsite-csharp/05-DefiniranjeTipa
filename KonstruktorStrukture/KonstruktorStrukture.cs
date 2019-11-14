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
			
			Udaljenost uda = new Udaljenost(23, JedinicaDuljine.Metar);
			Console.WriteLine(uda.Broj);
			Console.WriteLine(uda.Jedinica);
		}

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
			Udaljenost udal = new Udaljenost(34);
			Console.WriteLine(udal.Broj);
			Console.WriteLine(udal.Jedinica);
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
