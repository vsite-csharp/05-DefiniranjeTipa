namespace Vsite.CSharp.DefiniranjeTipa
{
    static class Internal
    {
        static void Main(string[] args)
        {
            IspišiIzvedenuIzJavne();

            IspišiIzvedenuIzBazne();

            IspišiIzvedenuIzInterneBazne();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static void IspišiIzvedenuIzJavne()
        {
            // DONE:030 Definiciju klase IzvedenaIzJavneBazne promijenite tako da je ona izvedena iz klase JavnaBazna.
            IzvedenaIzJavneBazne izvedenaIzJavne = new IzvedenaIzJavneBazne();
            // DONE:031 Otkomentirajte donju naredbu, prevedite kod i provjerite radi li poziv ispravno.
            izvedenaIzJavne.IspišiMe();
        }

        public static void IspišiIzvedenuIzBazne()
        {
            // DONE:032 Definiciju klase IzvedenaIzBazne promijenite tako da je ona izvedena iz klase Bazna. Prevedite kod i popravite pogreške koje prevoditelj prijavljuje.
            // DONE:033 Promijenite pravo pristupa klasi Bazna da se kod može prevesti.
            IzvedenaIzBazne izvedenaIzBazne = new IzvedenaIzBazne();
            // DONE:034 Otkomentirajte donju naredbu, prevedite kod i provjerite radi li poziv ispravno.
            izvedenaIzBazne.IspišiMe();
        }

        public static void IspišiIzvedenuIzInterneBazne()
        {
            // DONE:035 U klasi IzvedenaIzInterneBazne treba, bez promjene prava pristupa, omogućiti poziv metode IspišiMe iz klase InternaBazna ali bez promjene koda klase InternaBazna!
            IzvedenaIzInterneBazne izvedenaIzInterne = new IzvedenaIzInterneBazne();
            // DONE:036 Otkomentirati donju naredbu i provjeriti izvođenje.
            izvedenaIzInterne.IspišiMe();
        }

        // DONE:037 Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestInternal
    }
}
