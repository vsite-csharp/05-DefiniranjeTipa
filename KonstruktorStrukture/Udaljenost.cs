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

        
		/*public Udaljenost()
		{
			Broj = 13.12;
			Jedinica = JedinicaDuljine.Centimetar;
		}*/
		
		public Udaljenost(double b, JedinicaDuljine j)
		{
			Broj = b;
			Jedinica = j;
		}
		public Udaljenost(double b)
		{
			Broj = b;
			Jedinica = JedinicaDuljine.Metar;
		}
		
	}
}
