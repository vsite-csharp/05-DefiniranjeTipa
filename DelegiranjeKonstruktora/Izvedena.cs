namespace Vsite.CSharp.DefiniranjeTipa
{
    class Izvedena // : Bazna
    {
        public readonly int B;
        private int a;

        public Izvedena(Izvedena izvedena) //: this.(Izvedena.a)
        {
            
            System.Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));
        }

        public Izvedena(int a, int b)
        {
            this.a = a;
            B = b;
            System.Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }

        
        // 080 Proglasiti da je ova klasa izvedena iz klase Bazna te joj definirati konstruktor s dva argumenta ("a" i "b") tipa int, 
        // kojima će se inicijalizirati članovi A i B. Konstruktor treba pozivati konstruktor bazne klase s jednim argumentom i proslijediti mu argument a.
        // TODO:081 U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));

        // 084 Dodati konstruktor s jednim argumentom "a" tipa int. Taj konstruktor treba pozvati ("delegirati") prethodno definirani konstruktor 
        // klase Izvedena s dva argumenta s time da je prvi argument "a", a drugi argument je 0. 
        // TODO:085 U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));

    }
}
