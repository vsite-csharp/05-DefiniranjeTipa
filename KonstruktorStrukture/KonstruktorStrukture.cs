using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // :070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            Udaljenost udaljenost = new Udaljenost();
            //Console.WriteLine("PozivPodrazumijevanogKonstruktora");
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);

            // :072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
            var udaljenost2 = new Udaljenost();
            //Console.WriteLine("PozivPodrazumijevanogKonstruktora 2");
            Console.WriteLine(udaljenost2.Broj);
            Console.WriteLine(udaljenost2.Jedinica);

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // :074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            Udaljenost udaljenost = new Udaljenost(broj, jedinica);
            //Console.WriteLine("PozivKonstruktoraSDvaArgumenta");
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // :076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.
            Udaljenost udaljenost = new Udaljenost(broj);
            //Console.WriteLine("PozivKonstruktoraSJednimArgumentom");
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);
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
