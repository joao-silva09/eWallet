using eWallet.Domain.Models.Enums;

namespace eWallet.API.DTOs.Divida
{
    public class AddDividaDto
    {
        public string Titulo { get; set; }
        public string NomeDevedor { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataVencimento { get; set; }
        public TipoDivida TipoDivida { get; set; }
    }
}
