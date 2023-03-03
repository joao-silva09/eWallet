using eWallet.Domain.Models.Enums;

namespace eWallet.API.DTOs.Conta
{
    public class AddContaDto
    {
        public string Titulo { get; set; }
        public decimal Saldo { get; set; }
        public Banco Banco { get; set; }
    }
}
