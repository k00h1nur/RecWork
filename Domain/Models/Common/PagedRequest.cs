using System.Text.Json.Serialization;

namespace Domain.Models.Common;

public record PagedRequest
{
    public ushort PageNumber { get; init; } 
    public ushort PageSize { get; init; }
    [JsonIgnore]
    public bool All => PageNumber == 0 && PageSize == 0;
}