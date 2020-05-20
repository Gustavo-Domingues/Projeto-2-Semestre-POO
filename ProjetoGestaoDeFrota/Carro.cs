using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    class Carro : Veiculo
    {
        #region Construtor
        public Carro(string placa, double capacidadeTanque, double consumo) : base(placa, capacidadeTanque, new Alcool(consumo))
        {
            
        }
        #endregion

        #region Métodos
        public override void addRota(DateTime data, int Kmrota)
        {
            Rota rota = new Rota(Kmrota, data);
        }
        public override double reabastecer()
        {
            return 1;
        }
        #endregion

        #region ToString para retorno
        public override string ToString()
        {
            return Placa;
        }
        #endregion
    }
}
