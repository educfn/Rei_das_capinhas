using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei_das_capinhas
{
    class CapaDeCelular
    {
        public float Valor_unitario { get; set; }
        public int Tamanho_lote { get; set; }

        public CapaDeCelular(float valor_monetario, int tamanho_lote)
        {
            Valor_unitario = valor_monetario;
            Tamanho_lote = tamanho_lote;
        }

    }
}
