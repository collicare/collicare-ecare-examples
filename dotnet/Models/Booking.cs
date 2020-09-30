using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Booking
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("dbid")]
    public string Dbid { get; set; }

    [JsonPropertyName("db")]
    public string Db { get; set; }

    [JsonPropertyName("db_type")]
    public string DbType { get; set; }

    [JsonPropertyName("customer_id")]
    public string CustomerId { get; set; }

    [JsonPropertyName("customer_dbid")]
    public string CustomerDbid { get; set; }

    [JsonPropertyName("org_unit")]
    public string OrgUnit { get; set; }

    [JsonPropertyName("order_id")]
    public string OrderId { get; set; }

    [JsonPropertyName("order_dbid")]
    public string OrderDbid { get; set; }

    [JsonPropertyName("order_ref")]
    public string OrderRef { get; set; }

    [JsonPropertyName("consignment_id")]
    public string ConsignmentId { get; set; }

    [JsonPropertyName("total_kg")]
    public decimal? TotalKg { get; set; }

    [JsonPropertyName("total_kg_freight")]
    public decimal? TotalKgFreight { get; set; }

    [JsonPropertyName("total_lm")]
    public decimal? TotalLm { get; set; }

    [JsonPropertyName("total_m3")]
    public decimal? TotalM3 { get; set; }

    [JsonPropertyName("total_packages")]
    public decimal? TotalPackages { get; set; }

    [JsonPropertyName("from_country")]
    public string FromCountry { get; set; }

    [JsonPropertyName("from_geo")]
    public string FromGeo { get; set; }

    [JsonPropertyName("from_ccg")]
    public string FromCcg { get; set; }

    [JsonPropertyName("from_name")]
    public string FromName { get; set; }

    [JsonPropertyName("from_address1")]
    public string FromAddress1 { get; set; }

    [JsonPropertyName("from_place")]
    public string FromPlace { get; set; }

    [JsonPropertyName("from_zipcode")]
    public string FromZipcode { get; set; }

    [JsonPropertyName("loading_country")]
    public string LoadingCountry { get; set; }

    [JsonPropertyName("loading_geo")]
    public string LoadingGeo { get; set; }

    [JsonPropertyName("loading_ccg")]
    public string LoadingCcg { get; set; }

    [JsonPropertyName("loading_name")]
    public string LoadingName { get; set; }

    [JsonPropertyName("loading_address1")]
    public string LoadingAddress1 { get; set; }

    [JsonPropertyName("loading_place")]
    public string LoadingPlace { get; set; }

    [JsonPropertyName("loading_zipcode")]
    public string LoadingZipcode { get; set; }

    [JsonPropertyName("to_country")]
    public string ToCountry { get; set; }

    [JsonPropertyName("to_geo")]
    public string ToGeo { get; set; }

    [JsonPropertyName("to_ccg")]
    public string ToCcg { get; set; }

    [JsonPropertyName("to_name")]
    public string ToName { get; set; }

    [JsonPropertyName("to_address1")]
    public string ToAddress1 { get; set; }

    [JsonPropertyName("to_place")]
    public string ToPlace { get; set; }

    [JsonPropertyName("to_zipcode")]
    public string ToZipcode { get; set; }

    [JsonPropertyName("unloading_country")]
    public string UnloadingCountry { get; set; }

    [JsonPropertyName("unloading_geo")]
    public string UnloadingGeo { get; set; }

    [JsonPropertyName("unloading_ccg")]
    public string UnloadingCcg { get; set; }

    [JsonPropertyName("unloading_name")]
    public string UnloadingName { get; set; }

    [JsonPropertyName("unloading_address1")]
    public string UnloadingAddress1 { get; set; }

    [JsonPropertyName("unloading_place")]
    public string UnloadingPlace { get; set; }

    [JsonPropertyName("unloading_zipcode")]
    public string UnloadingZipcode { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("status_full")]
    public string StatusFull { get; set; }

    [JsonPropertyName("departure_status")]
    public string DepartureStatus { get; set; }

    [JsonPropertyName("arrival_status")]
    public string ArrivalStatus { get; set; }

    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    [JsonPropertyName("etd_success")]
    public bool? EtdSuccess { get; set; }

    [JsonPropertyName("eta_success")]
    public bool? EtaSuccess { get; set; }

    [JsonPropertyName("eta_total_kg")]
    public decimal? EtaTotalKg { get; set; }

    [JsonPropertyName("etd_total_kg")]
    public decimal? EtdTotalKg { get; set; }

    [JsonPropertyName("eta_total_kg_freight")]
    public decimal? EtaTotalKgFreight { get; set; }

    [JsonPropertyName("etd_total_kg_freight")]
    public decimal? EtdTotalKgFreight { get; set; }

    [JsonPropertyName("eta_total_lm")]
    public decimal? EtaTotalLm { get; set; }

    [JsonPropertyName("etd_total_lm")]
    public decimal? EtdTotalLm { get; set; }

    [JsonPropertyName("eta_total_m3")]
    public decimal? EtaTotalM3 { get; set; }

    [JsonPropertyName("etd_total_m3")]
    public decimal? EtdTotalM3 { get; set; }

    [JsonPropertyName("eta_total_packages")]
    public decimal? EtaTotalPackages { get; set; }

    [JsonPropertyName("etd")]
    public DateTime? Etd { get; set; }

    [JsonPropertyName("atd")]
    public DateTime? Atd { get; set; }

    [JsonPropertyName("eta")]
    public DateTime? Eta { get; set; }

    [JsonPropertyName("ata")]
    public DateTime? Ata { get; set; }

    [JsonPropertyName("order_date")]
    public DateTime? OrderDate { get; set; }

    [JsonPropertyName("min_date")]
    public DateTime? MinDate { get; set; }

    [JsonPropertyName("max_date")]
    public DateTime? MaxDate { get; set; }

    [JsonPropertyName("invoice_csv")]
    public string InvoiceCsv { get; set; }

    [JsonPropertyName("invoice_dbcsv")]
    public string InvoiceDbcsv { get; set; }

    [JsonPropertyName("trip_csv")]
    public string TripCsv { get; set; }

    [JsonPropertyName("trip_dbcsv")]
    public string TripDbcsv { get; set; }

    [JsonPropertyName("loading_ref")]
    public string LoadingRef { get; set; }

    [JsonPropertyName("unloading_ref")]
    public string UnloadingRef { get; set; }

    [JsonPropertyName("move_type")]
    public string MoveType { get; set; }

    [JsonPropertyName("loading_type")]
    public string LoadingType { get; set; }

    [JsonPropertyName("ext_cons_id")]
    public string ExtConsId { get; set; }

    [JsonPropertyName("hawb_id")]
    public string HawbId { get; set; }

    [JsonPropertyName("pol")]
    public string Pol { get; set; }

    [JsonPropertyName("pod")]
    public string Pod { get; set; }

    [JsonPropertyName("awb")]
    public string Awb { get; set; }

    [JsonPropertyName("client_name")]
    public string ClientName { get; set; }

    [JsonPropertyName("total_invoice_dkk")]
    public decimal? TotalInvoiceDkk { get; set; }

    [JsonPropertyName("total_invoice_eur")]
    public decimal? TotalInvoiceEur { get; set; }

    [JsonPropertyName("total_invoice_gbp")]
    public decimal? TotalInvoiceGbp { get; set; }

    [JsonPropertyName("total_invoice_nok")]
    public decimal? TotalInvoiceNok { get; set; }

    [JsonPropertyName("total_invoice_sek")]
    public decimal? TotalInvoiceSek { get; set; }

    [JsonPropertyName("total_invoice_usd")]
    public decimal? TotalInvoiceUsd { get; set; }

    [JsonPropertyName("total_invoice_lcy")]
    public decimal? TotalInvoiceLcy { get; set; }

    [JsonPropertyName("lcy_currency")]
    public string LcyCurrency { get; set; }

    [JsonPropertyName("incoterms")]
    public string Incoterms { get; set; }

    [JsonPropertyName("service_code")]
    public string ServiceCode { get; set; }

    [JsonPropertyName("original_received")]
    public bool? OriginalReceived { get; set; }

    [JsonPropertyName("container_type")]
    public string ContainerType { get; set; }

    [JsonPropertyName("container_teu")]
    public decimal? ContainerTeu { get; set; }

    [JsonPropertyName("container_id")]
    public string ContainerId { get; set; }

    [JsonPropertyName("containers_count")]
    public decimal? ContainersCount { get; set; }

    [JsonPropertyName("containers_teu")]
    public decimal? ContainersTeu { get; set; }

    [JsonPropertyName("containers_type_csv")]
    public string ContainersTypeCsv { get; set; }

    [JsonPropertyName("containers_id_csv")]
    public string ContainersIdCsv { get; set; }

    [JsonPropertyName("containers")]
    public List<BookingContainer> Containers { get; set; }
}
