using F1LiveTiming.Models;
using F1LiveTiming.Parsers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace F1LiveTimingAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class F1SessionDataController : ControllerBase
{
    [HttpGet(Name = "GetF1SessionData")]
    public async Task<F1SessionData> GetAsync()
    {
        // Drivers.
        var drivers = DriverInfoParser.Parse(await GetDriverInfoJson());
        
        // Lap count.
        var lapCount = LapCountParser.Parse(await GetLapCountJson());
        
        var sessionData = new F1SessionData
        {
            Drivers = drivers,
            LapCount = lapCount
        };
        
        return sessionData;
    }

    private static async Task<string> GetDriverInfoJson()
    {
        var client = new HttpClient
        {
            BaseAddress = new UriBuilder("https://localhost")
            {
                Port = 7035
            }.Uri
        };

        var httpResponse = await client.GetAsync("DriverList.json");
        
        httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299

        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

        using var streamReader = new StreamReader(contentStream);

        return await streamReader.ReadToEndAsync();
    }
    
    private static async Task<string> GetLapCountJson()
    {
        var client = new HttpClient
        {
            BaseAddress = new UriBuilder("https://localhost")
            {
                Port = 7035
            }.Uri
        };

        var httpResponse = await client.GetAsync("LapCount.jsonStream");
        
        httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299

        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

        using var streamReader = new StreamReader(contentStream);

        return await streamReader.ReadToEndAsync();
    }
}