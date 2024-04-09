using System;

public class StatisticsDisplay : IDisplay
{
    private double maxTemperature = double.MinValue;
    private double minTemperature = double.MaxValue;
    private double sumTemperature = 0;
    private int numReadings = 0;

    public void Update(double temperature, double humidity, double pressure)
    {
        maxTemperature = Math.Max(maxTemperature, temperature);
        minTemperature = Math.Min(minTemperature, temperature);
        sumTemperature += temperature;
        numReadings++;

        Console.WriteLine($"          Statistics: Max Temperature {maxTemperature}");
        Console.WriteLine($"          Statistics: Min Temperature {minTemperature});
        Console.WriteLine($"          Statistics: Average Temperature {sumTemperature / numReadings}");

    }
}
