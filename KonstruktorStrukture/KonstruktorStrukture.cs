namespace Vsite.CSharp.DefiniranjeTipa
{
    static class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // 070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            Udaljenost udaljenost = new Udaljenost();
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);

            // 072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
            Udaljenost udaljenostpk = new Udaljenost();
            Console.WriteLine(udaljenostpk.Broj);
            Console.WriteLine(udaljenostpk.Jedinica);
        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // 074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            Udaljenost udaljenost2 = new Udaljenost(3, JedinicaDuljine.Kilometar);
            Console.WriteLine(udaljenost2.Broj);
            Console.WriteLine(udaljenost2.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // 076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.
            Udaljenost udaljenost3 = new Udaljenost(3);
            Console.WriteLine(udaljenost3.Broj);
            Console.WriteLine(udaljenost3.Jedinica);
        }

        // 077 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestKonstruktoraStrukture

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
