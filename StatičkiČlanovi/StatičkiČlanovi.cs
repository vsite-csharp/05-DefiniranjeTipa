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

            mk2.IspišiRedniBrojObjekta();
            mk1.IspišiRedniBrojObjekta();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
