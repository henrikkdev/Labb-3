namespace Labb_3
{

    internal class TemperatureCalculator
    {
        private static double[] temperatures = new double[31];//array för alla dagar i maj 

        


        public TemperatureCalculator()
        {

            Random random = new Random();

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.Next(2, 20);//genererar tempraturer mellan 2 och 20 
            }
            
        }

        public void ListTemperatures()
        {
            Console.Clear();
            Console.WriteLine("Here are the temperatures for the month of May:");
            for (int i = 0;i < temperatures.Length;i++)
            {
                Console.WriteLine($"Dag {i + 1}: {temperatures[i]}°C");
            }
        }
        

    }
}
