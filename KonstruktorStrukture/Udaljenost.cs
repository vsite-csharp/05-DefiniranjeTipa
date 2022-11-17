﻿namespace Vsite.CSharp.DefiniranjeTipa
{
    enum JedinicaDuljine
    {
        Milimetar,
        Centimetar,
        Decimetar,
        Metar,
        Kilometar
    }

    struct Udaljenost
    {
        public readonly double Broj;
        public readonly JedinicaDuljine Jedinica;

        // :071 Dodati prazan konstruktor koji će inicijalizirati članove na neku vrijednost.
        //public Udaljenost(double broj, JedinicaDuljine jedinica)
        //{
        //    Broj = broj;
        //    Jedinica = jedinica;
        //}
        // :073 Promijeniti prazan konstruktor tako da prima dva argumenta ("broj" i "jedinica") kojima se inicijaliziraju članovi. 

        // TODO:075 Dodati konstruktor koji prima samo argument "broj", a član "Jedinica" će konstruktor postaviti na JedinicaDuljine.Metar.
        public Udaljenost(double broj, JedinicaDuljine jedinica = JedinicaDuljine.Metar)
        {
            Broj = broj;
            Jedinica = jedinica;
        }
    }
}
