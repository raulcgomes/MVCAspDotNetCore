using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAspDotNetCore.Models
{
    public class Context : DbContext
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=MVCAspDotNetCore;Integrated Security=True";

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: connectionString);
        }
    }
}
