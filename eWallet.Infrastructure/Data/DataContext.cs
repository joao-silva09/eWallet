﻿using eWallet.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace eWallet.Infrastructure.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Conta> Contas { get; set; }
        public DbSet<Divida> Dividas { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

