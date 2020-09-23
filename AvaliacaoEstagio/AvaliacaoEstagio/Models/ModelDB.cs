using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace AvaliacaoEstagio.Models
{

    /// <summary>
    /// DataModel criado pelo EF
    /// </summary>
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<tbUsuario> tbUsuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbUsuario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tbUsuario>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
