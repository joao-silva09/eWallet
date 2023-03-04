using eWallet.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eWallet.Infrastructure.Data

{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Divida> Dividas { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public string ObterStringConexao()
        {
            return "Data Source=JOAO\\SQLSERVER;Initial Catalog=eWalletAPI;Integrated Security=True; TrustServerCertificate=True;";
        }
    }
}

