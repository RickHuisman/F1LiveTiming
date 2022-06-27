using F1LiveTiming.Models;
using Newtonsoft.Json;

namespace F1LiveTiming.Parsers;

public static class DriverInfoParser
{
    public static IEnumerable<DriverInfo> Parse(string json)
    {
        var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, DriverInfo>>(json);
            
        // Convert to list.
        return jsonObject.Values.ToList();
    }
}