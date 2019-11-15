using System;
using System.Diagnostics;

namespace Vsite.CSharp.DefiniranjeTipa
{
    public class KlasaSDestruktorom
    {
        public KlasaSDestruktorom()
        {
            RedniBroj = ++Brojač;
            string poruka = string.Format("Konstruktor objekta br. {0}", RedniBroj);
            // ispis u konzolu
            Console.WriteLine(poruka);
            // dijagnostički ispis u Output prozor Visual Studija
            Debug.WriteLine(poruka);
        }

        ~KlasaSDestruktorom()
        {
            Console.WriteLine("Destruktor objekta br. {0}", RedniBroj);
        }


        public readonly int RedniBroj; // redni broj objekta

        static int Brojač = 0; // brojač ukupno stvorenih objekata
    }
}
