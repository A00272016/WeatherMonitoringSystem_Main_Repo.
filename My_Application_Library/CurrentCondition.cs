/// <summary>
/// This is for the current condition.
/// </summary>
public class CurrentCondition : IDisplay
{
    private readonly WeatherData weatherData;

    private CurrentCondition()
    {
        weatherData = WeatherData.GetInstance();
    }

    public static CurrentCondition GetInstance()
    {
        return new CurrentCondition();
    }

    public void Update()
    {
        Display();
    }

    public void Display()
    {
        float temperature = weatherData.GetTemperature();
        float humidity = weatherData.GetHumidity();
        float pressure = weatherData.GetPressure();

        // Display current conditions
        Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }
}