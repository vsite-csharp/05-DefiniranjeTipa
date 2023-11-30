namespace Vsite.CSharp.DefiniranjeTipa
{
    static class Destruktor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");
            {
                var ksd = new KlasaSDestruktorom();
            }

            for(int i = 0; i < 100000; i++) 
            {
                var ksd = new KlasaSDestruktorom();
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
