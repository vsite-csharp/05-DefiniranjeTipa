namespace Vsite.CSharp.DefiniranjeTipa
{
    class Bazna
    {
        protected Bazna(int a) // konstruktor je protected!
        {
            A = a;
            Console.WriteLine($"Bazna.Bazna(a: {a})");
        }

        public readonly int A;
    }
}
