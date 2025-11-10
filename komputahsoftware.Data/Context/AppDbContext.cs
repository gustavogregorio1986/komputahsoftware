using komputahsoftware.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komputahsoftware.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
            new Usuario
            {
                   Id = 1,
                   NomeUsuario = "gustavo",
                   Senha = BCrypt.Net.BCrypt.HashPassword("123456"),
                   Role = "User"
              }
            );


            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
