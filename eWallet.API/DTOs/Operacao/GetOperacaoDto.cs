using eWallet.API.DTOs.Conta;

using eWallet.Domain.Models.Enums;

namespace eWallet.API.DTOs.Operacao
{
    public class GetOperacaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataOperacao { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
        public GetContaDto Conta { get; set; }
    }
}
