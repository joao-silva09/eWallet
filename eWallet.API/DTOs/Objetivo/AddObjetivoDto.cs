using eWallet.Domain.Models.Enums;

namespace eWallet.API.DTOs.Objetivo
{
    public class AddObjetivoDto
    {
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public SituacaoObjetivo SituacaoObjetivo { get; set; }
    }

}
