using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using RestSharp;
using RestSharp.Extensions;

class Program
{
    static string ApiKey = "REPLACE_ME";
    static IRestClient apiClient = new RestClient("https://apidatav1.ecare.collicare.com/api/collidata/1.0").AddDefaultQueryParameter("key", ApiKey);

    static void Main(string[] args)
    {
        // Bookings
        var bookings = ListBookings();
        Console.WriteLine($"Found {bookings.Count} bookings");
        Console.WriteLine("First booking: " + JsonSerializer.Serialize(bookings.FirstOrDefault(), new JsonSerializerOptions { WriteIndented = true }));

        // Invoices
        var invoices = ListInvoices();
        Console.WriteLine($"Found {invoices.Count} invoices");
        Console.WriteLine("First invoice: " + JsonSerializer.Serialize(invoices.FirstOrDefault(), new JsonSerializerOptions { WriteIndented = true }));

        // Claims
        var claims = ListClaims();
        Console.WriteLine($"Found {claims.Count} claims");
        Console.WriteLine("First claim: " + JsonSerializer.Serialize(claims.FirstOrDefault(), new JsonSerializerOptions { WriteIndented = true }));
    }

    static List<Booking> ListBookings()
    {
        var request = new RestRequest("/bookings", DataFormat.Json);

        // Optional query string parameters. See http://apidatav1.ecare.collicare.com/swagger-ui for more.
        request.AddQueryParameter("page", "1");
        request.AddQueryParameter("size", "100");
        request.AddQueryParameter("sort", "order_date:desc");

        // Execute GET bookings request
        var response = apiClient.Execute<ListResponse<Booking>>(request);

        return response.Data.Data;
    }

    static List<Invoice> ListInvoices()
    {
        var request = new RestRequest("/invoices", DataFormat.Json);

        // Optional query string parameters. See http://apidatav1.ecare.collicare.com/swagger-ui for more.
        request.AddQueryParameter("size", "5");

        // Execute GET invoices request
        var response = apiClient.Execute<ListResponse<Invoice>>(request);

        return response.Data.Data;
    }

    static List<Claim> ListClaims()
    {
        var request = new RestRequest("/claims", DataFormat.Json);

        // Optional query string parameters. See http://apidatav1.ecare.collicare.com/swagger-ui for more.
        request.AddQueryParameter("size", "5");

        // Execute GET claims request
        var response = apiClient.Execute<ListResponse<Claim>>(request);

        return response.Data.Data;
    }
}

