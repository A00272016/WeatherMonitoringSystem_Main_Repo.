using System;

public class ForecastDisplay : IDisplay
{
    public void Update(double temperature, double humidity, double pressure)
    {
        string forecast;

        if (temperature > 25 && humidity > 50)
        {
            forecast = "Hot and Humid";
        }
        else if (temperature < 10)
        {
            forecast = "Cold";
        }
        else
        {
            forecast = "Moderate";
        }

        Console.WriteLine($"                   Forecast: {forecast}");
    }
}
