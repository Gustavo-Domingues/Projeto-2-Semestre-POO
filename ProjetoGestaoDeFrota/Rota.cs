using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGestaoDeFrota
{
    class Rota
    {
        private int _KmRota;
        private DateTime _Data;

        public Rota(int kmRota, DateTime data)
        {
            KmRota = kmRota;
            Data = data;
        }

        public int KmRota { get => _KmRota; set => _KmRota = value; }
        public DateTime Data { get => _Data; set => _Data = value; }
    }
}
