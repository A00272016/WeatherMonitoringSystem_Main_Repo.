/// <summary>
/// This is for the current condition.
/// </summary>
public class CurrentCondition : IDisplay
{
    private float temperature;
    private float humidity;
    private float pressure;

    public void Display(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        Console.WriteLine($"Current Conditions: {temperature}F, {humidity}% humidity, {pressure}Pa pressure");
    } 
}
