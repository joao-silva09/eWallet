using eWallet.API.DTOs.Conta;
using eWallet.Domain.Models.Enums;

namespace eWallet.API.DTOs.Divida
{
    public class GetDividaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string NomeDevedor { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public TipoDivida TipoDivida { get; set; }
        public SituacaoDivida SituacaoDivida { get; set; }
        public GetContaDto? Conta { get; set; }
    }
}
