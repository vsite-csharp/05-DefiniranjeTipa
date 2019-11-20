namespace Vsite.CSharp.DefiniranjeTipa
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
        public Udaljenost(double broj, JedinicaDuljine jedinica)
        {
            Broj = broj;
            Jedinica = jedinica;
        }

        public Udaljenost(double broj)
        {
            Broj = broj;
            Jedinica = JedinicaDuljine.Metar;
        }

        public readonly double Broj;
        public readonly JedinicaDuljine Jedinica;
    }
}
