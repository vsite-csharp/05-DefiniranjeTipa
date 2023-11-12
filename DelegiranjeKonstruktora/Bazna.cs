namespace Vsite.CSharp.DefiniranjeTipa
{
    class Bazna
    {
        protected Bazna(int a) // konstruktor je protected!
        {
            A = a;
            Console.WriteLine(string.Format("Bazna.Bazna({0})", a));
        }

        public readonly int A;
    }
}
