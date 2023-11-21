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

            // TODO:101 Dodati for petlju koja će se ponoviti 100000 puta i unutar koje će se kreirati novi objekti tipa KlasaSDestruktorom. Pokrenuti program i provjeriti redni broj prvog uništenog objekta.

            Console.WriteLine("Petlja je završila!!!");
            Console.WriteLine("Pritisni bilo koju tipku za završetak");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
