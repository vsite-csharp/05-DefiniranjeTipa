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
        public readonly double Broj;
        public readonly JedinicaDuljine Jedinica;
        public Udaljenost(double broj)
        {
            Broj = broj;
            Jedinica = JedinicaDuljine.Metar;
        }
        public Udaljenost(double broj,JedinicaDuljine jedinica)
        {
            this.Broj = broj;
            this.Jedinica = jedinica;
        }
        
    }
}
