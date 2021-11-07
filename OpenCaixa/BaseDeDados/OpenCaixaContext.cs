using Microsoft.EntityFrameworkCore;
using OpenCaixa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCaixa.BaseDeDados
{
    class OpenCaixaContext : DbContext
    {
        public class ApplicationDBContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=127.0.0.1;Port=3307;database=OpenCaixaDatabase;uid=root;pwd=Pft!zM0DyQRE;");
            }

            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<ItemVenda> ItemVendas { get; set; }
            public DbSet<Movimentacao> Movimentacaos { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }
        }
    }
}
