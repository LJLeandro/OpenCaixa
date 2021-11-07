using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCaixa.Modelos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public Categoria Categoria { get; set; }


        public Produto(string nome, double preco, int estoque = 0, Categoria categoria)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
            Categoria = categoria;
        }
    }
}
