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


    }

}
