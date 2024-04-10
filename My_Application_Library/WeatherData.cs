using System;
using System.Collection.Generic;

/// <summary>
/// This is for the weather data subject.
/// </summary>
public class WeatherData
{
    private static WeatherData instance;
    //private readonly Random random;
    private float temperature;
    private float humidity;
    private float pressure;

    private WeatherData()
    {
        //random = new Random();
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
        this.temperature = temperature; //random.Next(-20, 40);
        this.humidity = humidity; //random.Next(0, 100);
        this.pressure = pressure; //random.Next(980, 1040);
        MeasurementsChanged();
    }
    public void Subscribe(IDisplay display)
    {
        displays.Add(display)
    }
    
    public void Unsubscribe(IDisplay display)
    {
        displays.Remove(display)
    }

    private void MeasurementsChanged()
    {
        foreach (var display in displays)
        {
            display.Display(temperature,humidity,pressure);
        }
    }
}
