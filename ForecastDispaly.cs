/// <summary>
/// This is for the weather forecast display.
/// </summary>
public class ForecastDisplay : IDisplay
{
    // private readonly WeatherData weatherData;

    // private ForecastDisplay()
    // {
    //     weatherData = WeatherData.GetInstance();
    // }

    // public static ForecastDisplay GetInstance()
    // {
    //     return new ForecastDisplay();
    // }

   

    
    public void Display(float temperature, float humidity, float pressure)
    {
        // Display forecast
        Console.WriteLine($"Forecast: Temperature {temperature}, Humidity {humidity}, Pressure {pressure}");
    }
}