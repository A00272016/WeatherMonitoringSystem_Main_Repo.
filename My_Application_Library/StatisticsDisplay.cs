//A00272016 Milan Pandya

///<summary>
///Represents the weather statistics display.
///</summary>
public class StatisticsDisplay : IDisplay
{
    private List<float> temperatures = new List<float>();

    public void Display(float temperature, float humidity, float pressure)
    {
        float average = temperatures.Count > 0 ? temperatures.Average() : 0;
        float max = temperatures.Count > 0 ? temperatures.Max() : 0;
        float min = temperatures.Count > 0 ? temperatures.Min() : 0;
        Console.WriteLine($"Average Temperature: {average}F, Max Temperature: {max}F, Min Temperature: {min}F");
    }
}
