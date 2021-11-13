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

        // 071 Dodati prazan konstruktor koji će inicijalizirati članove na neku vrijednost.
        public Udaljenost(double b, JedinicaDuljine jd)
        {
            Broj = b;
            Jedinica = jd;
        }

        public Udaljenost(double b)
        {
            Broj = b;
            Jedinica = JedinicaDuljine.Metar;
        }

        // 073 Promijeniti prazan konstruktor tako da prima dva argumenta ("broj" i "jedinica") kojima se inicijaliziraju članovi. 

        // 075 Dodati konstruktor koji prima samo argument "broj", a član "Jedinica" će konstruktor postaviti na JedinicaDuljine.Metar.
    }
}
