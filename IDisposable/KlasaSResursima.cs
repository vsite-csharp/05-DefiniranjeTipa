namespace Vsite.CSharp.DefiniranjeTipa
{
    internal class KlasaSResursima
    {
        // TODO:122 Deklarirati da klasa implementira IDisposable sučelje te dodati javnu metodu Dispose.
        // TODO:123 Poziv metode StreamWriter.Close prebaciti iz destruktora u virtualnu metodu Dispose.

        // TODO:128 Unutar virtualne metode dodati poziv metode UnmanagedApi.FreeMemory kojom će se osloboditi memorija alocirana prilikom poziva UnmanagedApi.GetString.

        // Upravljani resurs: StreamWriter implementira sučelje IDisposable i u finalizirajućoj metodi zatvara datoteku pa će GC znati osloboditi datoteku.
        private readonly StreamWriter sw;
        // Neupravljani resurs: pokazivač na memoriju koju je alocirao C programski kod i ta memorija nije pod kontrolom GC-a. 
        private readonly IntPtr neupravljaniResurs = IntPtr.Zero;

        public KlasaSResursima(string imeDatoteke)
        {
            sw = new StreamWriter(imeDatoteke);
            sw.AutoFlush = true;

            neupravljaniResurs = UnmanagedApi.GetString();
        }

        public void Zapiši(string? tekst)
        {
            sw.WriteLine(tekst);
        }

        public string? DajTekst()
        {
            unsafe
            {
                return new string((sbyte*)neupravljaniResurs);
            }
        }

        // TODO:121 Dodati klasi destruktor koji će pozvati metodu StreamWriter.Close (odn. StreamWriter.Dispose). Pokrenuti program i provjeriti ispis.
    }
}
