using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    class Caminhao : Veiculo
    {
        
        public Caminhao(string placa) : base(placa,new Diesel())
        {

        }

        public override void addRota(DateTime data, int Kmrota)
        {
            Rota rota = new Rota(Kmrota, data);
        }

        public override double reabastecer()
        {
            return 1;
        }

        public override string ToString()
        {
            return Placa;
        }
    }
}
