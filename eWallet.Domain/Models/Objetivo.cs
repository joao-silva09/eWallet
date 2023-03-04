using eWallet.Domain.Models.Enums;
using eWallet.Infrastructure.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace eWallet.Domain.Models
{
    public class Objetivo
    {
        public long Id { get; set; }

        public string Titulo { get; set; }

        public string? Descricao { get; set; }

        public decimal Valor { get; set; }

        public SituacaoObjetivo SituacaoObjetivo { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public Conta? Conta { get; set; }
    }
}
