using System;
using System.Text.Json.Serialization;

public class Invoice
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("dbid")]
    public string Dbid { get; set; }

    [JsonPropertyName("db")]
    public string Db { get; set; }

    [JsonPropertyName("db_type")]
    public string DbType { get; set; }

    [JsonPropertyName("invoice_date")]
    public DateTime? InvoiceDate { get; set; }

    [JsonPropertyName("due_date")]
    public DateTime? DueDate { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("customer_id")]
    public string CustomerId { get; set; }

    [JsonPropertyName("customer_dbid")]
    public string CustomerDbid { get; set; }

    [JsonPropertyName("customer_name")]
    public string CustomerName { get; set; }

    [JsonPropertyName("amount")]
    public decimal? Amount { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }
}
