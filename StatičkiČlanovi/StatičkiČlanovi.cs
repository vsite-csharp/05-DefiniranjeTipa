namespace Vsite.CSharp.StatičkiČlanovi
{
    static class Program
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

            mk1.IspišiRedniBrojObjekta();
            mk2.IspišiRedniBrojObjekta();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
