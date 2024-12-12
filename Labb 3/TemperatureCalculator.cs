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

        public void Printdateandtemp()
        {
            //printar värmen för varje dag 
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"day {i + 1}: {temperatures[i]}°C");
            }
        }

        //Temp sorterare
        public void PrintTempSorter(bool ascending = true)
        {
            var temperaturesWithDays = temperatures.Select((temp, index) => new { Day = index + 1, temperatures = temp });
            if (ascending )
            {
                temperaturesWithDays = temperaturesWithDays.OrderBy(t => t.temperatures);
            }
            else
            {
                temperaturesWithDays = temperaturesWithDays.OrderByDescending(t => t.temperatures);
            }

            Console.WriteLine(ascending ? "\nTemperaturer sorterade efter kyla:" :  "\nTemperaturer sorterade efter värme:");
            foreach (var item in temperaturesWithDays)
            {
                Console.WriteLine($"Dag {item.Day}: {item.temperatures}°C");
            }
        }


        //medeltemp
        public double GetAverageTemperature()
        {
            return temperatures.Average();
        }
        public void PrintAverageTemperature()
        {
            Console.WriteLine($"\nMedeltemperatur: {GetAverageTemperature()}°C");
        }

        //högsta temp och dagen det skedde
        public void GetMaxTemp()
        {
            double maxTemp = temperatures.Max();
            int day = Array.IndexOf(temperatures, maxTemp) + 1;
            Console.WriteLine($"\nhögsta temp: {maxTemp}°C på dag {day}");
        }

        //mintemp
        public void GetMinTemperature()
        {
            double minTemp = temperatures.Min();
            int day = Array.IndexOf(temperatures, minTemp) + 1;
            Console.WriteLine($"\nminsta temp: {minTemp}°C på dag {day}");
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
            Console.WriteLine($"\nMedian temp: {GetMedianTemp()}°C");
        }

        //temperaturer över en tröskel
        public void Tempfilter(double threshold)
        {
            var TempFilterd = temperatures.Where(t => t > threshold).ToArray();
            Console.WriteLine($"Days with temps over {threshold}°C");
            for (int i = 0; i < TempFilterd.Length; i++)
            {
                int day = Array.IndexOf(temperatures, TempFilterd[i])+ 1;
                Console.WriteLine($"Day {day}: {TempFilterd[i]}°C");
            }
        }
        
        //Temp för specefik dag
        public void GetTemperatureOfDay(int day)
        {
            if (day < 1 || day > 31)
            {
                Console.WriteLine("Ogiltig dag");
                return;
            }

            double todayTemp = temperatures[day - 1];
            double prevDayTemp = day >1 ? temperatures[day - 2] : double.NaN;
            double nextDayTemp = day < 31 ? temperatures[day] : double.NaN;

            Console.WriteLine($"Temp för dag {day}: {todayTemp}°C");
            if(!double.IsNaN(prevDayTemp)) Console.WriteLine($"dagen före {day - 1}: {prevDayTemp}°C");
            if (!double.IsNaN(nextDayTemp)) Console.WriteLine($"dagen efter {day + 1}: {nextDayTemp}°C");
        }

        //mest förekommande temp
        public void GetMostFrequentTemperature()
        {
            var frequency = temperatures.GroupBy(t => t).OrderByDescending(g =>g.Count()).FirstOrDefault();
            if (frequency != null)
            {
                Console.WriteLine($"\nDen vanligaste temperaturen är {frequency.Key}°C\n");
            }
            else
            {
                Console.WriteLine("Inget data tillgängliga.");
            }
        }

        
    }

}
