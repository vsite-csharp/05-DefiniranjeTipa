namespace Vsite.CSharp.DefiniranjeTipa
{
    // TODO:122 Deklarirati da klasa implementira IDisposable sučelje te dodati javnu metodu Dispose.
    // TODO:123 Dodati u klasu metodu protected virtual void Dispose(bool disposing) i u nju prebaciti poziv StreamWriter.Close iz destruktora.
    // TODO:124 Napraviti pozive metode iz destruktora i iz javne metode Dispose.
    class RadSdatotekom : IDisposable
    {
        private readonly StreamWriter sw;
        private bool disposedValue;

        public RadSdatotekom(string imeDatoteke)
        {
            sw = new StreamWriter(imeDatoteke);
            sw.AutoFlush = true;
        }

        public void Zapiši(string tekst)
        {
            sw.Write(tekst);
        }

        // TODO:121 Dodati klasi destruktor koji će pozvati metodu StreamWriter.Close (odn. StreamWriter.Dispose). Pokrenuti program i provjeriti ispis.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    sw.Close();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~RadSdatotekom()
        {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
             Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    static class Disposable
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            using RadSdatotekom rd = new RadSdatotekom(imeDatoteke);
            rd.Zapiši("Ovo je moj upis");
            //rd.Dispose();

            // TODO:125 Dodati poziv metode RadSDatotekom.Dispose.

            // TODO:127 Preraditi kod metode tako da se umjesto metode Dispose koristi blok using.

        }

        // TODO:126 Staviti točku prekida (breakpoint) na poziv metode BrisanjeDatoteke, pokrenuti program i provjeriti sadržaj datoteke prije brisanja.
        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }

        // TODO:120 Pokrenuti program i pogledati ispis. Provjeriti sadržaj datoteke "moj.txt".
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
            Console.ReadKey();
        }
    }
}
