using F1LiveTiming.Models;
using Newtonsoft.Json;

namespace F1LiveTiming.Parsers;

public static class LapCountParser
{
    public static IEnumerable<LapCount> Parse(string json)
    {
        var lines = JsonStreamParser.SplitIntoLines(json);

        var counts = new List<LapCount>();
        
        foreach (var line in lines)
        {
            var lapCount = JsonConvert.DeserializeObject<LapCount>(line.Data, new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore
            });
            counts.Add(lapCount);
        }

        return counts;
    }
}