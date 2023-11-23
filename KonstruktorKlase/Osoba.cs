namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()
        {
            Ime = "Pero";
            Prezime = "Perić";
            DatumRođenja = new DateTime(1993, 12, 3);
        }

        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
        public Osoba(string ime, string prezime, DateTime datumRođenja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRođenja = datumRođenja;
        }
    }
}
