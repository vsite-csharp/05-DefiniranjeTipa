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

        public Udaljenost(double broj, JedinicaDuljine jedinica)
        {
            this.Broj = broj;
            this.Jedinica = jedinica;
        }
        
        public Udaljenost(double broj)
        {
            this.Broj = broj;
            this.Jedinica = JedinicaDuljine.Metar;
        }


    }
}
