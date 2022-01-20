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

        public virtual DbSet<Categoria> Categorias { get; set; }

        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: connectionString);
        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
