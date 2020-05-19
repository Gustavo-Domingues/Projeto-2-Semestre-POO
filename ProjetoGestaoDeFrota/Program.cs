using System;

namespace ProjetoGestaoDeFrota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja mudar o valor ou consumo dos combustíveis?");
            int x = int.Parse(Console.ReadLine());
            if (x==1)
            {
                Console.Write("Digite o Valor do Alcool: ");
                double valAlc = double.Parse(Console.ReadLine());
                Alcool alc = new Alcool(valAlc);

                Console.Write("Digite o Valor do Diesel: ");
                double valDie = double.Parse(Console.ReadLine());
                Diesel die = new Diesel(valDie);

                Console.Write("Digite o Valor da Gasolina: ");
                double valGas = double.Parse(Console.ReadLine());
                Gasolina gas = new Gasolina();
            }

            Caminhao c = new Caminhao("qni-2439");
            c.addRota(DateTime.Now,100);
           Console.WriteLine( c.ToString());
        }
    }
}
