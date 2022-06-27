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
        var drivers = DriverInfoParser.Parse(await streamReader.ReadToEndAsync());
        
        var sessionData = new F1SessionData
        {
            Drivers = drivers,
        };
        
        return sessionData;
    }
}