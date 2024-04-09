using System;

public class CurrentConditionsDisplay : IDisplay
{
    public void Update(double temperature, double humidity, double pressure)
    {
        Console.WriteLine($"Current Conditions: Temperature {temperature}, Humidity {humidity}, Pressure {pressure}");
    }
}
