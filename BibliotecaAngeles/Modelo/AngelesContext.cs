using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BibliotecaAngeles.Modelo
{
    public class AngelesContext : DbContext
    {
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
        public AngelesContext() : base("name=ConexionBD")
        {
        }

        public DbSet<Boleta> Boletas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Producto> Producto { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
  
    }
}
