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


        public Produto(int codigo, string nome, double preco, Categoria categoria, int estoque = 0)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
            Categoria = categoria;
        }
    }
}
