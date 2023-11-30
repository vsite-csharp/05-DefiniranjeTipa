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

            // :101 Dodati for petlju koja će se ponoviti 100000 puta i unutar koje će se kreirati novi objekti tipa KlasaSDestruktorom. Pokrenuti program i provjeriti redni broj prvog uništenog objekta.
            for(int i = 0; i < 100000; ++i) 
            {
                var ksd = new KlasaSDestruktorom();
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");

            int[] polje = new int[1000];
        }
    }
}
