using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{
    internal class TemperatureCalculator
    {
        private static double[] temperatures = new double[31];//array för alla dagar i maj 
        private const string FilePath = "temperatures.txt";



        public TemperatureCalculator()
        {
            Random random = new Random();

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.Next(2, 20);//genererar tempraturer mellan 2 och 20 
            }
            
        }

        public string TemperatureList()
        {
            Console.WriteLine("Temps in may");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Dag {i + 1}: {temperatures[i]}°C");
            }
            return $"{temperatures}";
        }
    }
}
