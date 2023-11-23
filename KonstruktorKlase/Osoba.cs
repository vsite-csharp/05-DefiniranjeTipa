namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // :061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.

        public Osoba(string ime, string prezime, DateTime datumrođenja) 
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumrođenja;
        }

        // :062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
    }
}
