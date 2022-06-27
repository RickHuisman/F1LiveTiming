namespace F1LiveTiming.Parsers;

public static class JsonStreamParser
{
    public static List<DataWithTimestamp> SplitIntoLines(string json)
    {
        var data = new List<DataWithTimestamp>();

        var lines = json.Split('\n');
        foreach (var line in lines)
        {
            var timestamp = line[..12];

            var dataWithTimestamp = new DataWithTimestamp
            {
                Timestamp = timestamp,
                Data = line[12..]
            };

            data.Add(dataWithTimestamp);
        }

        return data;
    }

    public class DataWithTimestamp
    {
        public string Timestamp { get; set; }
        public string Data { get; set; }
    }
}