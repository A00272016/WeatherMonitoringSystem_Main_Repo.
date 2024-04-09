using System;

namespace WeatherMonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = WeatherData.Instance;

            Console.WriteLine("Enter 'q' to quit or any other key to generate random weather data:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                    break;

                weatherData.GenerateRandomData();
            }
        }
    }
}
