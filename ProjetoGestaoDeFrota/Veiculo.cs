using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    abstract class Veiculo
    {
        private string _placa;
        private IAbastecimento _tanque;

        public Veiculo(string placa,  IAbastecimento tanque)
        {
            Placa = placa;
            Tanque = tanque;
        }

        public string Placa { get => _placa; set => _placa = value; }
        internal IAbastecimento Tanque { get => _tanque; set => _tanque = value; }

        public abstract void addRota(DateTime data, int kmRota);
        public abstract double reabastecer();

        
    }
}
