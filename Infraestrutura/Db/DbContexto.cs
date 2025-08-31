using Microsoft.EntityFrameworkCore;
using Minimal_Api.Dominio.Entidades;

namespace Minimal_Api.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        public DbSet<Administrador> administradores { get; set; } = default;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseMySql(
                "conexao",
            ServerVersion.AutoDetect("conexao")
           );
        }
    }
}