using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    class Van : Veiculo
    {
        #region Construtor
        public Van(string placa) : base(placa,60, new Gasolina(7))
        {
           
        }
        #endregion

        #region Métodos
        public override void addRota(DateTime data, int Kmrota)
        {
            if (Kmrota > (CapacidadeTanque * Tanque.consumo()))
            {
                // Retorno para informar impossibilidade de percurso
            }
            else
            {
                if (Kmrota < (QuantidadeLitrosAtual * Tanque.consumo()))
                {
                    double quantGasto = Kmrota / Tanque.consumo();
                    QuantidadeLitrosAtual -= quantGasto;
                    rota.Data = data;
                    rota.KmRota = Kmrota;
                }
                else
                {
                    double _litrosParaAbastecer = Kmrota - QuantidadeLitrosAtual;
                    reabastecer(_litrosParaAbastecer);
                }
            }
        }
        #endregion
    }
}
