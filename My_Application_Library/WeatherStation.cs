namespace My_Application_Library;

/// <summary>
/// Represents the weather station factory.
/// </summary>
public class WeatherStation
{
    public static IDisplay SelectDisplay(string choice)
    {
        switch (choice)
        {
            case "1":
               CurrentCondition A = new CurrentCondition();
               return A;
                //break;
            // case "2":
            //     ForecastDisplay B = new ForecastDisplay();
            //    return B;                
            //    //break;
            // case "3":
            //     StatisticsDisplay C = new StatisticsDisplay();
            //    return C;                
            //    //break;
            default:
            throw new Exception("Invalid Input");
        }
    }
}
