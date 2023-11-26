namespace Vsite.CSharp.DefiniranjeTipa
{
    static class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // 070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.

            Udaljenost d = new Udaljenost();
            Console.WriteLine(d.Broj);
            Console.WriteLine(d.Jedinica);



			// 072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
		





		}

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // 074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.

            Udaljenost d3 = new Udaljenost(broj,jedinica);
            Console.WriteLine(d3.Broj);
            Console.WriteLine(d3.Jedinica);




        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // 076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.

            Udaljenost d4 = new Udaljenost(broj);
            Console.WriteLine(d4.Broj);
            Console.WriteLine(d4.Jedinica);

        }

        // T077 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestKonstruktoraStrukture

        static void Main(string[] args)
        {

            PozivPodrazumijevanogKonstruktora();

            PozivKonstruktoraSDvaArgumenta(5, JedinicaDuljine.Kilometar);

            PozivKonstruktoraSJednimArgumentom(17);

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
