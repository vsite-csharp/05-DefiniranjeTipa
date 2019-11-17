﻿using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // TODO:070 Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            // TODO:072 Stvoriti objekt pozivom praznog konstruktora te ispisati vrijednosti članova.
            Udaljenost udaljenost = new Udaljenost();
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);
        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // TODO:074 Stvoriti objekt pozivom konstruktora koji prima dva argumenta te ispisati vrijednosti članova.
            Udaljenost udaljenost = new Udaljenost(broj, jedinica);
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);
        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // TODO:076 Stvoriti objekt pozivom konstruktora s jednim argumentom te ispisati vrijednosti članova.
            Udaljenost udaljenost = new Udaljenost(broj);
            Console.WriteLine(udaljenost.Broj);
            Console.WriteLine(udaljenost.Jedinica);
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
