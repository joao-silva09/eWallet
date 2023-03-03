using eWallet.API.DTOs.Conta;
using eWallet.Domain.Models.Enums;

namespace eWallet.API.DTOs.Objetivo
{
    public class GetObjetivoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public SituacaoObjetivo SituacaoObjetivo { get; set; }
        public GetContaDto? Conta { get; set; }

    }
}
