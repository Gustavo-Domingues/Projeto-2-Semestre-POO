using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    class Alcool : IAbastecimento
    {
        private static double _valorLitro;
        private double _consumo;
        public Alcool()
        {
        }

        public Alcool(double ValLit)
        {
            ValorLitro1 = ValLit;
        }

        public Alcool(double consumo, double valorLitro1)
        {
            Consumo = consumo;
            ValorLitro1 = valorLitro1;
        }

        public double Consumo { get => _consumo; set => _consumo = value; }
        public double ValorLitro1 { get => _valorLitro; set => _valorLitro = value; }

        public double consumo()
        {
            return Consumo;
        }

        public double ValorLitro()
        {
            return ValorLitro1;
        }
    }
}
