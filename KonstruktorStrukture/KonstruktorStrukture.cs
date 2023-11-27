namespace Vsite.CSharp.DefiniranjeTipa
{
    static class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // :070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            Udaljenost u = new Udaljenost();
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);

            // :072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
            Udaljenost up = new Udaljenost();
            Console.WriteLine(up.Broj);
            Console.WriteLine(up.Jedinica);


        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // :074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            Udaljenost u = new Udaljenost(broj, jedinica);
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);
        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // :076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.
            Udaljenost u = new Udaljenost(broj);
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);
        }

        // :077 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestKonstruktoraStrukture

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
