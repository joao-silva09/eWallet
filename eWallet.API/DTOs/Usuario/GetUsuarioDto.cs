using eWallet.API.DTOs.Conta;
using eWallet.API.DTOs.Divida;
using eWallet.API.DTOs.Objetivo;
using eWallet.API.DTOs.Operacao;

namespace eWallet.API.DTOs.Usuario
{
    public class GetUsuarioDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<GetObjetivoDto> Objetivos { get; set; }
        public List<GetContaDto> Contas { get; set; }
        public List<GetDividaDto> Dividas { get; set; }
        public List<GetOperacaoDto> Operacoes { get; set; }
    }
}
