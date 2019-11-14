using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Osoba   //DZ
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        // TODO:061 Dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
        public Osoba()//prazni konstruktor...članovi gore će imati vrijednost
        {
            Ime = "Milan";
            Prezime = "Bandić";
            DatumRođenja = new DateTime(1756,12,3);
            /*Nakon gornjih izmjena ispis: Milan
Bandic
3.12.1756. 0:00:00*/
        }
        // TODO:062 Promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
        public Osoba(string ime,string prezime,DateTime datumRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja =datumRođenja;
        }
       
        
    }
}
