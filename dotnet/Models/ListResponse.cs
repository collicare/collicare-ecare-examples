using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ListResponse<T>
{
    [JsonPropertyName("data")]
    public List<T> Data { get; set; }
}