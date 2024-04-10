/// <summary>
/// Represents the weather statistics display.
/// </summary>
public class StatisticsDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    private StatisticsDisplay()
    {
        weatherData = WeatherData.GetInstance();
    }

    public static StatisticsDisplay GetInstance()
    {
        return new StatisticsDisplay();
    }

    public void Update()
    {
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Weather statistics:");
    }
    public void Display(float temperature, float humidity, float pressure)
    {
        // Display statistics
        Console.WriteLine($"Statistics: Temperature {temperature}, Humidity {humidity}, Pressure {pressure}");
    }
}