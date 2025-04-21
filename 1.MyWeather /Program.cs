using System;
using System.Collections.Generic;
using System.Linq;

namespace MyWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyWeather!");
            Console.WriteLine("Please enter the number of days you would like to see the weather for:");

            // Get number of forecast days from user
            int days = int.Parse(Console.ReadLine());

            // Arrays to hold temperature and weather conditions
            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            // Generate random weather data
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-20, 55); // Random temperature between -20°C and 54°C

                if (temperature[i] < 0)
                    weatherConditions[i] = "Snowy";
                else if (temperature[i] < 10)
                    weatherConditions[i] = "Rainy";
                else if (temperature[i] < 20)
                    weatherConditions[i] = "Cloudy";
                else
                    weatherConditions[i] = "Sunny";
            }

            // Display weather report
            Console.WriteLine("\nDay\tTemperature\tConditions");
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"{i + 1}\t{temperature[i]}\t\t{weatherConditions[i]}");
            }

            // Display weather statistics
            float average = AverageTemperature(temperature);
            Console.WriteLine($"\nThe average temperature for the next {days} days is {average}");

            Console.WriteLine($"The maximum temperature is {temperature.Max()}");
            Console.WriteLine($"The minimum temperature is {temperature.Min()}");

            string mostCommonCondition = MostCommonWeatherCondition(weatherConditions);
            Console.WriteLine($"The most common weather condition is {mostCommonCondition}");
        }

        // Method to calculate average temperature
        static float AverageTemperature(int[] temperature)
        {
            float sum = 0;
            foreach (int temp in temperature)
            {
                sum += temp;
            }
            return sum / temperature.Length;
        }

        // Method to determine the most frequently occurring weather condition
        static string MostCommonWeatherCondition(string[] weatherConditions)
        {
            Dictionary<string, int> weatherCount = new Dictionary<string, int>();

            foreach (string condition in weatherConditions)
            {
                if (weatherCount.ContainsKey(condition))
                    weatherCount[condition]++;
                else
                    weatherCount[condition] = 1;
            }

            string mostCommon = "";
            int maxCount = 0;

            foreach (var entry in weatherCount)
            {
                if (entry.Value > maxCount)
                {
                    maxCount = entry.Value;
                    mostCommon = entry.Key;
                }
            }

            return mostCommon;
        }
    }
}
