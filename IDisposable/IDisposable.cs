using System;
using System.IO;

namespace Vsite.CSharp.DefiniranjeTipa
{
    // Deklarirati da klasa implementira IDisposable sučelje te dodati javnu metodu Dispose.
    // Dodati u klasu metodu protected virtual void Dispose(bool disposing) i u nju prebaciti poziv StreamWriter.Close iz destruktora.
    // Napraviti pozive metode iz destruktora i iz javne metode Dispose.
    class RadSdatotekom : IDisposable
    {
        private StreamWriter sw;
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    sw.Close();
                }
                
                disposed = true;
            }
        }

        public RadSdatotekom(string imeDatoteke)
        {
            sw = new StreamWriter(imeDatoteke);
        }
        

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
      
        public void Zapiši(string tekst)
        {
            sw.Write(tekst);
        }

        // Dodati klasi destruktor koji će pozvati metodu StreamWriter.Close (odn. StreamWriter.Dispose). Pokrenuti program i provjeriti ispis.
        ~RadSdatotekom()
        {
           sw.Close();
            Dispose(false);
            
        }
    }

    class Disposable 
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            RadSdatotekom rd = new RadSdatotekom(imeDatoteke);
            rd.Zapiši("Ovo je moj upis");

            // Dodati poziv metode RadSDatotekom.Dispose.
            rd.Dispose();

            // Preraditi kod metode tako da se umjesto metode Dispose koristi blok using.
            using (StreamWriter sw2 = new StreamWriter(imeDatoteke))
            {
                sw2.WriteLine("Ovo je moj novi upis");
            }

        }

        // Staviti točku prekida (breakpoint) na poziv metode BrisanjeDatoteke, pokrenuti program i provjeriti sadržaj datoteke prije brisanja.
        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }

        // Pokrenuti program i pogledati ispis. Provjeriti sadržaj datoteke "moj.txt".
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
