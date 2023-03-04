using eWallet.Domain.Models.Enums;
using eWallet.Infrastructure.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace eWallet.Domain.Models
{
    public class Conta
    {
        public long Id { get; set; }

        public string Titulo { get; set; }

        public decimal Saldo { get; set; }

        public Banco Banco { get; set; }

        public IEnumerable<Divida>? Dividas { get; set; }

        public IEnumerable<Operacao>? Operacoes { get; set; }

        public IEnumerable<Objetivo>? Objetivos { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
