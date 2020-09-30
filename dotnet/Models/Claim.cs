using System;
using System.Text.Json.Serialization;

public class Claim
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("db")]
    public string Db { get; set; }

    [JsonPropertyName("customer_id")]
    public string CustomerId { get; set; }

    [JsonPropertyName("created_date")]
    public DateTime? CreatedDate { get; set; }

    [JsonPropertyName("changed_date")]
    public DateTime? ChangedDate { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("category_name")]
    public string CategoryName { get; set; }

    [JsonPropertyName("person_name")]
    public string PersonName { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}
