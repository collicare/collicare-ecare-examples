using System.Text.Json.Serialization;

public class BookingContainer {
    [JsonPropertyName("no")]
    public string No { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("teu")]
    public decimal? Teu { get; set; }
}
