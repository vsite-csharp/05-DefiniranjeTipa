using System;
using System.IO;

namespace Vsite.CSharp.DefiniranjeTipa
{
    class Disposable
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            StreamWriter sw = new StreamWriter(imeDatoteke);
            sw.WriteLine("Ovo je moj upis");

            /*Usao sam u main
             * Konstruktor objekta br. 1
                Konstruktor objekta br. 2
                Konstruktor objekta br. 3
                Konstruktor objekta br. 4
         *              .....
         *      Destruktor objekta br. 985
                Destruktor objekta br. 984
                Destruktor objekta br. 983
                Destruktor objekta br. 982
                Destruktor objekta br. 981
                Destruktor objekta br. 980
                Destruktor objekta br. 979
                (stop)
                 Destruktor objekta br. 1000 */
           
            //sw.Close(); //isto kao i sw.Dispose ili ili...pozivanje eksplicitno 
            sw.Dispose();//Bez ovog neće moći obrisati datoteku  
            

            //osim eksplicitnog moguće je napraviti i ovako (dolje)
            //možda bolje rješenje 
            using (StreamWriter ssw = new StreamWriter(imeDatoteke))
            {
                sw.WriteLine("Ovo je 2. moj upis");
            }

        }

        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }


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
