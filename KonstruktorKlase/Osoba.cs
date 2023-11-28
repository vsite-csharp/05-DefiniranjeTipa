namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // DONE:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()
        {
            this.Ime = "Pero";
            this.Prezime = "Perić";
            this.DatumRođenja = DateTime.Now;
        }

        public Osoba (string name, string lastname, DateTime dob)
        {
            this.Ime = name;
            this.Prezime = lastname;
            this.DatumRođenja = dob;
        }
        // DONE:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
    }
}
