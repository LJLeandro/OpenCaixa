using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCaixa.Modelos
{
    public class ItemVenda
    {
        public int Codigo { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public double ValorTotal { get; set; }
        public List<Movimentacao>? Movimentacoes { get; set; }

        public ItemVenda(int codigo, DateTime dataHoraVenda, double valorTotal)
        {
            Codigo = codigo;
            DataHoraVenda = dataHoraVenda;
            ValorTotal = valorTotal;
        }
    }
}
