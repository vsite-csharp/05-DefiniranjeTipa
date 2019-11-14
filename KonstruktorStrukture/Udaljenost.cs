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

        //struktura ne može imati implementirani konstruktor bez parametara

        public Udaljenost(double broj, JedinicaDuljine jedinica)
        {
            Broj = broj;
            Jedinica = jedinica;
        }
        public Udaljenost(double broj) : this(broj, JedinicaDuljine.Metar)
        {
            Broj = broj;
        }
    }
}
