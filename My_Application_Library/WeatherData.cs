/// <summary>
/// This is for the weather data subject.
/// </summary>
public class WeatherData
{
    private static WeatherData instance;
    private readonly Random random;
    private float temperature;
    private float humidity;
    private float pressure;

    private WeatherData()
    {
        random = new Random();
    }
    private List<IDisplay> shows = new List<IDisplay>();
    public static WeatherData GetInstance
    {
        get
        {
        return instance ??= new WeatherData();
        }
    }

    public void subscribe
    public void SetMeasurements()
    {
        temperature = random.Next(-20, 40);
        humidity = random.Next(0, 100);
        pressure = random.Next(980, 1040);
        MeasurementsChanged();
    }
    private void MeasurementsChanged()
    {
        CurrentCondition.GetInstance().Update();
        StatisticsDisplay.GetInstance().Update();
        ForecastDisplay.GetInstance().Update();
    }
}
