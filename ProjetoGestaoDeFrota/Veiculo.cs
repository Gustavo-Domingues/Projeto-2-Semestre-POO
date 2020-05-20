using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    abstract class Veiculo
    {

        //Classe abstrata 

        private string _placa;
        private IAbastecimento _tanque;
        private double _capacidadeTanque;

        public Veiculo(string placa, double capacidadeTanque,  IAbastecimento tanque)
        {
            Placa = placa;
            CapacidadeTanque = capacidadeTanque;
            Tanque = tanque;
        }

        public string Placa { get => _placa; set => _placa = value; }
        public double CapacidadeTanque { get => _capacidadeTanque; set => _capacidadeTanque = value; }
        internal IAbastecimento Tanque { get => _tanque; set => _tanque = value; }

        public abstract void addRota(DateTime data, int kmRota);
        public abstract double reabastecer();

        
    }
}
