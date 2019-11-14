using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    class Program
    {
        static void Main(string[] args)
        {
            BrojačInstanci.IspišiBrojStvorenihObjekata();

            BrojačInstanci mk1 = new BrojačInstanci();
            mk1.IspišiRedniBrojObjekta();

            BrojačInstanci.IspišiBrojStvorenihObjekata();

            BrojačInstanci mk2 = new BrojačInstanci();
            mk2.IspišiRedniBrojObjekta();

            BrojačInstanci.IspišiBrojStvorenihObjekata();
            //mk1.IspišiRedniBrojObjekta();   //2
            //mk2.IspišiRedniBrojObjekta(); //2
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
