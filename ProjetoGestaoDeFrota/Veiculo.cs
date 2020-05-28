using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProjetoGestaoDeFrota
{
    abstract class Veiculo
    {
        private string _placa;
        private IAbastecimento _tanque;
        private double _capacidadeTanque;
        private double _quantidadeLitrosAtual;
        private double _gastoComCombustivel;

        public Rota rota = new Rota();

        public Veiculo(string placa, double capacidadeTanque,  IAbastecimento tanque)
        {
            Placa = placa;
            CapacidadeTanque = capacidadeTanque;
            Tanque = tanque;
            QuantidadeLitrosAtual = CapacidadeTanque;
            GastoComCombustivel = CapacidadeTanque * Tanque.valorLitro();
        }

        public string Placa { get => _placa; set => _placa = value; }
        public double CapacidadeTanque { get => _capacidadeTanque; set => _capacidadeTanque = value; }
        public double QuantidadeLitrosAtual { get => _quantidadeLitrosAtual; set => _quantidadeLitrosAtual = value; }
        public double GastoComCombustivel { get => _gastoComCombustivel; set => _gastoComCombustivel = value; }
        internal IAbastecimento Tanque { get => _tanque; set => _tanque = value; }

        public double reabastecer(double _litros)
        {
            QuantidadeLitrosAtual += _litros;
            GastoComCombustivel += (_litros * Tanque.valorLitro());
            return QuantidadeLitrosAtual;
        }
        public abstract void addRota(DateTime data, int kmRota);


        #region ToString para retorno
        public override string ToString()
        {
            return "Veículo: " + Placa + ", Dia da rota: " +rota+ ", Km da rota: " + rota.KmRota + ", Total: R$" + GastoComCombustivel +
                ", Litros restantes: "+QuantidadeLitrosAtual+"\n";
        }
        #endregion
    }
}
