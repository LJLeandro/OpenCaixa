using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCaixa.Modelos
{
    class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public Permissao Permissao { get; set; }
        public string Senha { get; set; }

        public Usuario(int codigo, string nome, string apelido, Permissao permissao, string senha)
        {
            Codigo = codigo;
            Nome = nome;
            Apelido = apelido;
            Permissao = permissao;
            Senha = senha;
        }
    }

    public enum Permissao
    {
        Caixa, Gerente, Administrador
    }
}
