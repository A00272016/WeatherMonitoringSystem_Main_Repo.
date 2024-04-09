using System;

public static class WeatherStation
{
    public static IDisplay CreateDisplay(DisplayType type)
    {
        switch (type)
        {
            case DisplayType.CurrentConditions:
                return new CurrentConditionsDisplay();
            case DisplayType.Statistics:
                return new StatisticsDisplay();
            case DisplayType.Forecast:
                return new ForecastDisplay();
            default:
                throw new ArgumentException("Invalid display type.");
        }
    }
}

public enum DisplayType
{
    CurrentConditions,
    Statistics,
    Forecast
}
