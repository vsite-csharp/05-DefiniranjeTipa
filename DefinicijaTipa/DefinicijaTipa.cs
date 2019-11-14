using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {
        private int broj;
        public MojaKlasa(int broj){
            this.broj = broj;
        }
        

        public void IspisiClan(){
            Console.WriteLine(this.broj);
        }
    }


    struct MojaStruktura
    {
        private string tekst;
        public MojaStruktura(string tekst){
            this.tekst = tekst;
        }
        


        public void IspisiClan(){
            Console.WriteLine(this.tekst);
        }
    }


    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa objekt = new MojaKlasa(5);
            objekt.IspisiClan();

        }

        public static void IspišiČlanStrukture()
        {
            MojaStruktura objekt = new MojaStruktura("MojaStruktura");
            objekt.IspisiClan();

        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
