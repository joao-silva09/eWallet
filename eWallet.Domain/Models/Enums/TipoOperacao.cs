using System.Text.Json.Serialization;

namespace eWallet.Domain.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoOperacao
    {
        Gasto = 1,
        Recebimento = 2,
        Transferência = 3
    }
}
