using F1LiveTiming.Models;

namespace F1LiveTimingAPI;

public class F1SessionData
{
    public IEnumerable<DriverInfo> Drivers { get; set; }
    public IEnumerable<LapCount> LapCount { get; set; }
}