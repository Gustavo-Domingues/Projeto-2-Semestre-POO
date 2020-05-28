using System;

namespace ProjetoGestaoDeFrota
{
    class Program
    {
        static void Main(string[] args)
        {
            Caminhao c = new Caminhao("OLR-1574");
            c.addRota(DateTime.Today, 200);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
