namespace Vsite.CSharp.DefiniranjeTipa
{
    internal static class UnmanagedApi
    {
        // Deklaracije poziva metoda iz neupravljanog (unmanaged) DLL-a.

        // Ova metoda u C kodu alocira memoriju za tekst, popuni memoriju tekstom i vraća pokazivač na tu memoriju.
        [System.Runtime.InteropServices.DllImport(@"../../../../x64/Debug/Unmanaged.dll")]
        public static extern IntPtr GetString();

        // Ova metoda u C kodu oslobađa memoriju na koju pokazuje prosljeđeni pokazivač.
        [System.Runtime.InteropServices.DllImport(@"../../../../x64/Debug/Unmanaged.dll")]
        public static extern void FreeMemory(IntPtr ptr);
    }
}
