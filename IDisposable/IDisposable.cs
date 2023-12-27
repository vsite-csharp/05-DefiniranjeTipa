namespace Vsite.CSharp.DefiniranjeTipa
{
    static class Disposable
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            var rd = new KlasaSResursima(imeDatoteke);
            rd.Zapiši("Ovo je moj upis");

            var neupravljaniText = rd.DajTekst();
            Console.WriteLine(neupravljaniText);
            rd.Zapiši(neupravljaniText);


            // TODO:125 Dodati poziv metode Dispose u klasi KlasaSResursima.

            // TODO:127 Preraditi kod metode tako da se umjesto metode Dispose koristi blok using.

        }

        // TODO:126 Staviti točku prekida (breakpoint) na poziv metode BrisanjeDatoteke, pokrenuti program i provjeriti sadržaj datoteke prije brisanja.
        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }

        // TODO:120 Provjeriti što donji kod radi. Pokrenuti program i pogledati ispis. Provjeriti sadržaj datoteke "moj.txt" prije brisanja.
        static void Main(string[] args)
        {
            try
            {
                StvaranjeIPisanjeUDatoteku("moj.txt");
                Console.WriteLine("Brišem datoteku");
                BrisanjeDatoteke("moj.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
