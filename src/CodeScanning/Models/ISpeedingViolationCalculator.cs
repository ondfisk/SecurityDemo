namespace CodeScanning.Models;

public interface ISpeedingViolationCalculator
{
    int DetermineSpeedingViolationInKmh(DateTime entryTimestamp, DateTime exitTimestamp);
    string GetRoadId();
}
