using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    class Gasolina : IAbastecimento
    {
        private static double _valorLitro;
        private double _consumo;
        public Gasolina()
        {

        }
        public Gasolina(double ValLit)
        {
            ValorLitro1 = ValLit;
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
