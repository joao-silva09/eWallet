﻿using eWallet.Domain.Models.Enums;

namespace eWallet.API.DTOs.Operacao
{
    public class AddOperacaoDto
    {
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataOperacao { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
    }
}
