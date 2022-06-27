using Newtonsoft.Json;

namespace F1LiveTiming.Models;

public class DriverInfo
{
    [JsonProperty("RacingNumber")] public int RacingNumber { get; set; }

    [JsonProperty("BroadcastName")] public string BroadcastName { get; set; }

    [JsonProperty("FullName")] public string FullName { get; set; }

    [JsonProperty("Tla")] public string Tla { get; set; }

    [JsonProperty("Line")] public int Line { get; set; }

    [JsonProperty("TeamName")] public string TeamName { get; set; }

    [JsonProperty("TeamColour")] public string TeamColour { get; set; }

    [JsonProperty("FirstName")] public string FirstName { get; set; }

    [JsonProperty("LastName")] public string LastName { get; set; }

    [JsonProperty("Reference")] public string Reference { get; set; }

    [JsonProperty("HeadshotUrl", NullValueHandling = NullValueHandling.Ignore)]
    public Uri HeadshotUrl { get; set; }

    [JsonProperty("CountryCode")] public string CountryCode { get; set; }

    [JsonProperty("NameFormat", NullValueHandling = NullValueHandling.Ignore)]
    public string NameFormat { get; set; }
}