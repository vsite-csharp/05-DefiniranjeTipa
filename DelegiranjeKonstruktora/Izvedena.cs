namespace Vsite.CSharp.DefiniranjeTipa
{
    class Izvedena : Bazna
    {
        public readonly int B;

        public Izvedena(int a, int b) : base(a)
        {
            B = b;
            Console.WriteLine($"Izvedena.Izvedena(a:{a}, b: {b})");

        }

        public Izvedena(int a) : this(a,0)
        {

            Console.WriteLine($"Izvedena.Izvedena(a: {a})");
        }

        // TODO:080 Proglasiti da je ova klasa izvedena iz klase Bazna te joj definirati konstruktor s dva argumenta ("a" i "b") tipa int, 
        // kojima će se inicijalizirati članovi A i B. Konstruktor treba pozivati konstruktor bazne klase s jednim argumentom i proslijediti mu argument a.

        // TODO:081 U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine($"Izvedena.Izvedena(a: {a}, b: {b})");

        // TODO:084 Dodati konstruktor s jednim argumentom "a" tipa int. Taj konstruktor treba pozvati ("delegirati") prethodno definirani konstruktor 
        // klase Izvedena s dva argumenta s time da je prvi argument "a", a drugi argument je 0. 

        // TODO:085 U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine($"Izvedena.Izvedena(a: {a})");

    }
}
