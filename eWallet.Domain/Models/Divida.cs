using eWallet.Domain.Models.Enums;
using eWallet.Infrastructure.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace eWallet.Domain.Models
{
    public class Divida
    {
        public long Id { get; set; }

        public string Titulo { get; set; }

        public string NomeDevedor { get; set; }

        public string? Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime? DataVencimento { get; set; }

        public DateTime? DataPagamento { get; set; }

        public TipoDivida TipoDivida { get; set; }

        public SituacaoDivida SituacaoDivida { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public Conta? Conta { get; set; }
    }
}
