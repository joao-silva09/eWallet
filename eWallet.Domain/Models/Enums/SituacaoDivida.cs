using System.Text.Json.Serialization;

namespace eWallet.Domain.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SituacaoDivida
    {
        Ativa = 1,
        Paga = 2
    }
}
