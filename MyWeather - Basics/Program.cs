namespace MyWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyWeather!");
            Console.WriteLine("Please enter the number of days you would like to see the weather for:");
            int days = int.Parse(Console.ReadLine());

            int[] temparature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days]; 

            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temparature[i] = random.Next(-20, 55);
                if (temparature[i] < 0)
                {
                    weatherConditions[i] = conditions[3];
                }
                else if (temparature[i] < 10)
                {
                    weatherConditions[i] = conditions[1];
                }
                else if (temparature[i] < 20)
                {
                    weatherConditions[i] = conditions[2];
                }
                else
                {
                    weatherConditions[i] = conditions[0];
                }
            }

            Console.WriteLine("Day\tTemperature\tConditions");
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"{i + 1}\t{temparature[i]}\t\t{weatherConditions[i]}");
            }
            float average = averageTemperature(temparature);
            Console.WriteLine($"The average temperature for the next {days} days is {average}");

            Console.WriteLine($"The maximum temperature is {temparature.Max()}");
            Console.WriteLine($"The minimum temperature is {temparature.Min()}");

            string mostCommonCondition = MostCommonWeatherCondition(weatherConditions);
            Console.WriteLine($"The most common weather condition is {mostCommonCondition}");

        }

        static float averageTemperature(int[] temparature)
        {
            float sum = 0;
            for (int i = 0; i < temparature.Length; i++)
            {
                sum += temparature[i];
            }
            return sum / float.Parse(temparature.Length.ToString());
        }

        static string MostCommonWeatherCondition(string[] weatherConditions)
        {
            Dictionary<string, int> weatherCount = new Dictionary<string, int>();
            foreach (string condition in weatherConditions)
            {
                if (weatherCount.ContainsKey(condition))
                {
                    weatherCount[condition]++;
                }
                else
                {
                    weatherCount[condition] = 1;
                }
            }
            int maxCount = 0;
            string mostCommonCondition = "";
            foreach (KeyValuePair<string, int> condition in weatherCount)
            {
                if (condition.Value > maxCount)
                {
                    maxCount = condition.Value;
                    mostCommonCondition = condition.Key;
                }
            }
            return mostCommonCondition;
        }
    }
}