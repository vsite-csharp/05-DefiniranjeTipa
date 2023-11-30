namespace Vsite.CSharp.DefiniranjeTipa
{
    // :122 Deklarirati da klasa implementira IDisposable sučelje te dodati javnu metodu Dispose.
    // :123 Dodati u klasu metodu protected virtual void Dispose(bool disposing) i u nju prebaciti poziv StreamWriter.Close iz destruktora.
    // :124 Napraviti pozive metode iz destruktora i iz javne metode Dispose.
    class RadSdatotekom : IDisposable
    {
        private readonly StreamWriter sw;
        private bool _disposedValue;

        public RadSdatotekom(string imeDatoteke)
        {
            sw = new StreamWriter(imeDatoteke);
            sw.AutoFlush = true;
        }

        public void Zapiši(string tekst)
        {
            sw.Write(tekst);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // : dispose managed state (managed objects)
                    sw.Close();
                }

                // : free unmanaged resources (unmanaged objects) and override finalizer
                // : set large fields to null
                _disposedValue = true;
            }
        }

        // : override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~RadSdatotekom()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        // :121 Dodati klasi destruktor koji će pozvati metodu StreamWriter.Close (odn. StreamWriter.Dispose). Pokrenuti program i provjeriti ispis.
    }

    static class Disposable
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            using RadSdatotekom rd = new RadSdatotekom(imeDatoteke);

            //RadSdatotekom rd = new RadSdatotekom(imeDatoteke);
            rd.Zapiši("Ovo je moj upis");

            // :125 Dodati poziv metode RadSDatotekom.Dispose.
            //rd.Dispose();

            // :127 Preraditi kod metode tako da se umjesto metode Dispose koristi blok using.

        }

        // :126 Staviti točku prekida (breakpoint) na poziv metode BrisanjeDatoteke, pokrenuti program i provjeriti sadržaj datoteke prije brisanja.
        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }

        // : Pokrenuti program i pogledati ispis. Provjeriti sadržaj datoteke "moj.txt".
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
