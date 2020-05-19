using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    class Van : Veiculo
    {
        double quantLitro;
        public Van(string placa, int kmRota, DateTime data, IAbastecimento tanque) : base(placa, tanque)
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
    }
}
