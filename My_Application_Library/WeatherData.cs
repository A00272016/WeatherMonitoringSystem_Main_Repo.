//A00272016 Milan Pandya

using System.Collections.Generic;
///<summary>
///This is for the weather data subject.
///</summary>
public class WeatherData
{
    private static WeatherData instance;
    //private readonly Random random;
    public float temperature;
    public float humidity;
    public float pressure;

    private WeatherData()
    {
       
    }
    private List<IDisplay> displays = new List<IDisplay>();

    public static WeatherData Instance
    {
        get
        {
            if(instance == null)
            {
            return instance = new WeatherData();
            }
            return instance;
        }
    }
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity; 
        this.pressure = pressure; 
        MeasurementsChanged();
    }
    public void Subscribe(IDisplay display)
    {
        displays.Add(display);
    }
    
    public void Unsubscribe(IDisplay display)
    {
        displays.Remove(display);
    }

    private void MeasurementsChanged()
    {
        foreach (var display in displays)
        {
            display.Display(temperature,humidity,pressure);
        }
    }
}
