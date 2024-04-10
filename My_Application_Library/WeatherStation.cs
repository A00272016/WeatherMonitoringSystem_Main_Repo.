/// <summary>
/// Represents the weather station factory.
/// </summary>
public class WeatherStation
{
    public void IDisplay SelectDisplay(string choice)
    {
        switch (choice)
        {
            case "1":
               CurrentCondition A = new CurrentCondition();
               return A;
                //break;
            case "2":
                ForecastDisplay B = new ForecastDisplay();
               return B;                
               //break;
            case "3":
                StatisticsDisplay C = new StatisticsDisplay();
               return C;                
               //break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }
    }
}
