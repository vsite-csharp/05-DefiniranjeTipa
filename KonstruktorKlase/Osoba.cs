namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // :061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()
        {
            Ime = "Pero";
            Prezime = "Peric";
            DatumRođenja = DateTime.Now;
        }
        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
        public Osoba(string ime, string prezime,  DateTime datumRodenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRodenja;
        }
    }
}
