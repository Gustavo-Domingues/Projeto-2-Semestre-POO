using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProjetoGestaoDeFrota
{
    class Rota
    {
       
        private int _KmRota;

        private DateTime data;
        
        public Rota()
        {

        }      

        public int KmRota { get => _KmRota; set => _KmRota = value; }
        public DateTime Data { get => data; set => data = value; }

        public override string ToString()
        {
            return data.ToString("dd-MM-yyyy");
        }
    }
}
