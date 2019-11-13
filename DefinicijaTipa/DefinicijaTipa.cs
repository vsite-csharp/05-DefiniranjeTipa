using System;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class MojaKlasa
    {      
       
        
       
        private int broj=5;
           
        public MojaKlasa(int broj)
        {
            this.broj = broj;

        }
        public int Broj
        {
            get { return broj; }
            set { this.broj = value; }
          
        }
        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }

    }


    struct MojaStruktura
    {
      
        //private string tekst = "MojaStruktura";
        private string tekst;
        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }
        public string Tekst 
        {
            get
            {
                return tekst;
            }
           
           
        }
      
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }

    class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
           
            int broj = 5;
            MojaKlasa definicijaTipa = new MojaKlasa(broj);
            definicijaTipa.IspišiČlan();

        }

        public static void IspišiČlanStrukture()
        {
            
            string tekst = "MojaStruktura";
            MojaStruktura struk = new MojaStruktura(tekst);
            struk.IspišiČlan();
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
