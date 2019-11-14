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

        public Udaljenost(double br, JedinicaDuljine jed) {
            Broj = br;
            Jedinica = jed;
        }
        public Udaljenost(double br) {
            Broj = br;
            Jedinica = JedinicaDuljine.Metar;
        }
    }
}
