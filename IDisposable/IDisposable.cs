namespace Vsite.CSharp.DefiniranjeTipa
{
	// 122 Deklarirati da klasa implementira IDisposable sučelje te dodati javnu metodu Dispose.
	// 123 Dodati u klasu metodu protected virtual void Dispose(bool disposing) i u nju prebaciti poziv StreamWriter.Close iz destruktora.
	// 124 Napraviti pozive metode iz destruktora i iz javne metode Dispose.
	class RadSdatotekom : IDisposable
    {
        private readonly StreamWriter sw;
		private bool disposedValues;

        public RadSdatotekom(string imeDatoteke)
        {
            sw = new StreamWriter(imeDatoteke);
            sw.AutoFlush = true;
        }

		public void Dispose()
		{   
			Dispose(true);
		}

		public void Zapiši(string tekst)
        {
            sw.Write(tekst);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!disposedValues)
            {
                if(disposing)
                {
                    sw.Close();
                }
            }
        }

        // 121 Dodati klasi destruktor koji će pozvati metodu StreamWriter.Close (odn. StreamWriter.Dispose). Pokrenuti program i provjeriti ispis.
        ~RadSdatotekom()
        {
            Dispose(disposing:false); 
        }

        
    }

    static class Disposable
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            using RadSdatotekom rd = new RadSdatotekom(imeDatoteke);
            rd.Zapiši("Ovo je moj upis");
            //rd.Dispose();

            // :125 Dodati poziv metode RadSDatotekom.Dispose.

            // 127 Preraditi kod metode tako da se umjesto metode Dispose koristi blok using.

        }

        // 126 Staviti točku prekida (breakpoint) na poziv metode BrisanjeDatoteke, pokrenuti program i provjeriti sadržaj datoteke prije brisanja.
        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }

        // :120 Pokrenuti program i pogledati ispis. Provjeriti sadržaj datoteke "moj.txt".
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
