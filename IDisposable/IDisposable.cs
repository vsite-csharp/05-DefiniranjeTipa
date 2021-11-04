using System;
using System.IO;

namespace Vsite.CSharp.DefiniranjeTipa
{
    //  Deklarirati da klasa implementira IDisposable sučelje te dodati javnu metodu Dispose.
    //  Dodati u klasu metodu protected virtual void Dispose(bool disposing) i u nju prebaciti poziv StreamWriter.Close iz destruktora.
    //Napraviti pozive metode iz destruktora i iz javne metode Dispose.
    class RadSdatotekom : IDisposable
    {
        private StreamWriter sw;

        public RadSdatotekom(string imeDatoteke)
        {
            sw = new StreamWriter(imeDatoteke);
        }

        public void Zapiši(string tekst)
        {
            sw.Write(tekst);
        }

        //  Dodati klasi destruktor koji će pozvati metodu StreamWriter.Close (odn. StreamWriter.Dispose). Pokrenuti program i provjeriti ispis.
        ~RadSdatotekom()
        {
            //sw?.Close();
            Dispose(false);
        }

        private void ReleaseUnmanagedResources()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();
            if (disposing)
            {
                sw?.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
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
            using (RadSdatotekom rd2 = new RadSdatotekom(imeDatoteke))
            {
                rd2.Zapiši("Ovo je moj upis");
            }


        }

        //  Staviti točku prekida (breakpoint) na poziv metode BrisanjeDatoteke, pokrenuti program i provjeriti sadržaj datoteke prije brisanja.
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
