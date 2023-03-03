namespace eWallet.API.DTOs.Objetivo
{
    public class UpdateObjetivoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
