using System.Text.Json.Serialization;

namespace eWallet.Domain.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoDivida
    {
        Gasto = 1,
        Recebimento = 2
    }
}
