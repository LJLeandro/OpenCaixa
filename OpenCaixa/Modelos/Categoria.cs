using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCaixa.Modelos
{
    public class Categoria
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }

        public List<Produto>? Produtos { get; set; }

        public Categoria(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
