using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string filePath = "E:\\SigntelGo\\TvGoServerless\\Excel\\ip_list.xlsx"; // Change path if needed
        
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Excel file not found.");
            return;
        }

        using var workbook = new XLWorkbook(filePath);
        var worksheet = workbook.Worksheets.Worksheet("Sheet1");

        int rowCount = worksheet.RowCount();

        for (int row = 2; row <= rowCount; row++) // Skip header
        {
            string ip = worksheet.Cell(row, 1).Value.ToString();

            if(string.IsNullOrEmpty(ip))
            {
                break;
            }

            IpLocation location = await ProcessIP(ip);

            worksheet.Cell(row, 2).Value = location?.country;
            worksheet.Cell(row, 3).Value = location?.region;
            worksheet.Cell(row, 4).Value = location?.city;
            worksheet.Cell(row, 5).Value = location?.readme;
            worksheet.Cell(row, 6).Value = location?.timezone;
            worksheet.Cell(row, 7).Value = location?.postal;
        }
        workbook.Save();
    }

    public static async Task<IpLocation> ProcessIP(string ip)
    {
        try
        {
            using HttpClient client = new();

            string apiUrl = $"https://ipinfo.io/{ip}";
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var location = JsonSerializer.Deserialize<IpLocation>(json);

                return location;
            }
            else
            {
                Console.WriteLine("Error retrieving IP details.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            return null;
        }
        return null;
    }
}

public class IpLocation
{
    public string country { get; set; }
    public string region { get; set; }
    public string city { get; set; }
    public string readme { get; set; }
    public string timezone { get; set; }
    public string postal { get; set; }
}