using Newtonsoft.Json;

namespace F1LiveTiming.Models;

public class LapCount
{
    [JsonProperty("CurrentLap")]
    public int CurrentLap { get; set; }

    [JsonProperty("TotalLaps")]
    public int? TotalLaps { get; set; }
}