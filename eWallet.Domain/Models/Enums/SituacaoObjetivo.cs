using System.Text.Json.Serialization;

namespace eWallet.Domain.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SituacaoObjetivo
    {
        Não_Cumprido = 1,
        Cumprido = 2
    }
}
