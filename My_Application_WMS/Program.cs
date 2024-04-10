﻿using My_Application_Library;

WeatherData wData = WeatherData.Instance;

wData.Subscribe(new CurrentCondition());


for (int i = 0; i < 5; i++)
        {
            Random rand = new Random();
            float temperature = rand.Next(60, 90);
            float humidity = rand.Next(40, 80);
            float pressure = rand.Next(990, 1010);
            wData.SetMeasurements(temperature, humidity, pressure);
            Console.WriteLine("-------------------");
        }