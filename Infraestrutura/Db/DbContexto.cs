using Microsoft.EntityFrameworkCore;
using Minimal_Api.Dominio.Entidades;

namespace Minimal_Api.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _appConfiguracao;
        public DbContexto(IConfiguration appConfiguracao)
        {
            _appConfiguracao = appConfiguracao;
        }
        public DbSet<Administrador>? administradores { get; set; } = default;
        public DbSet<Veiculo>? Veiculos { get; set; } = default;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().HasData(
                new Administrador
                {
                    Id = 1,
                    Email = "admin@teste.com",
                    Senha = "1234",
                    Perfil = "Adm"
                }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var stringConexao = _appConfiguracao.GetConnectionString("conexao")?.ToString();
                if (!string.IsNullOrEmpty(stringConexao))
                {
                    optionsBuilder.UseMySql(
                     stringConexao,
                     ServerVersion.AutoDetect(stringConexao)
                    );
                }
            }
        }
    }
}