using System.Text.Json.Serialization;

namespace Fluxeen.HexagonalEventDriven.Domain.Catalogs.DTOs;

public class ItemCatalogueDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}

public class CatalogueDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("items")]
    public List<ItemCatalogueDto> Catalogue { get; set; }
}
