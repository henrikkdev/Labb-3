using System.Numerics;

namespace Labb_3
{
    class TemperatureCalculator
    {
        //array för varje dag i maj
        private static double[] temperatures = new double[31];

        public TemperatureCalculator()
        {
            Random random = new Random();

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.Next(5, 20);
            }
        }

        public void PrintDateandTemp()
        {
            //printar värmen för varje dag 
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1:00}: {temperatures[i]}°C");
            }
        }

        //Temp sorterare
        public void PrintTempSorter(bool ascending = true)
        {
            var temperaturesWithDays = temperatures.Select((temp, index) => new { Day = index + 1, temperatures = temp });
            if (ascending)
            {
                temperaturesWithDays = temperaturesWithDays.OrderBy(t => t.temperatures);
            }
            else
            {
                temperaturesWithDays = temperaturesWithDays.OrderByDescending(t => t.temperatures);
            }

            Console.WriteLine(ascending ? "\nTemperatures sorted from cold to warm:" : "\nTemperatures sorted from warm to cold:");
            foreach (var item in temperaturesWithDays)
            {
                Console.WriteLine($"Day {item.Day:00}: {item.temperatures}°C");
            }
        }

        //medeltemp
        public double AverageTemp()
        {
            return Math.Round(temperatures.Average(), 2);
        }
        public void PrintAverageTemperature()
        {
            Console.WriteLine($"\nAverage temperature: {AverageTemp()}°C");
        }

        //högsta temp och dagen det skedde
        public void GetMaxTemp()
        {
            double maxTemp = temperatures.Max();
            int day = Array.IndexOf(temperatures, maxTemp) + 1;
            Console.WriteLine($"\nHighest temperature: {maxTemp}°C, on day: {day:00}");
        }

        //mintemp
        public void GetMinTemp()
        {
            double minTemp = temperatures.Min();
            int day = Array.IndexOf(temperatures, minTemp) + 1;
            Console.WriteLine($"\nLowest temperature: {minTemp}°C, on day: {day:00}");
        }

        //median
        public double GetMedianTemp()
        {
            var sortedTemps = temperatures.OrderBy(t => t).ToArray();
            int middleIndex = sortedTemps.Length / 2;

            if (sortedTemps.Length % 2 == 0)
            {
                return (sortedTemps[middleIndex - 1] + sortedTemps[middleIndex]) / 2;
            }
            else
            {
                return (sortedTemps[middleIndex]);
            }
        }
        public void PrintMedianTemp()
        {
            Console.WriteLine($"\nMedian temperature: {GetMedianTemp()}°C");
        }

        //temperaturer över en tröskel
        public void Tempfilter(double threshold)
        {
            Console.WriteLine($"Days with temperatures over {threshold}°C:");

            // Iterera manuellt genom arrayen och kontrollera temperaturen
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] >= threshold)
                {
                    Console.WriteLine($"Day {i + 1:00}: {temperatures[i]}°C");
                }
            }
        }

        //Temp för specefik dag
        public void GetTempOfDay(int day)
        {
            if (day < 1 || day > 31)
            {
                Console.WriteLine("Error, please choose a day between 1 and 31.");
                return;
            }

            double todayTemp = temperatures[day - 1];
            double prevDayTemp = day > 1 ? temperatures[day - 2] : double.NaN;
            double nextDayTemp = day < 31 ? temperatures[day] : double.NaN;

            Console.WriteLine($"Temperature for day {day:00}: {todayTemp}°C");
            if (!double.IsNaN(prevDayTemp)) Console.WriteLine($"The day before {day - 1:00}: {prevDayTemp}°C");
            if (!double.IsNaN(nextDayTemp)) Console.WriteLine($"The day after {day + 1:00}: {nextDayTemp}°C");
        }

        //mest förekommande temp
        public void GetMostFrequentTemp()
        {
            var frequency = temperatures.GroupBy(t => t).OrderByDescending(g => g.Count()).FirstOrDefault();
            if (frequency != null)
            {
                Console.WriteLine($"\nThe most frequent temperature for may was: {frequency.Key}°C\n");
            }
            else
            {
                Console.WriteLine("No data available.");
            }
        }


    }

}
