namespace Labb_3
{

    internal class TemperatureCalculator
    {
        private static double[] temperatures = new double[31];//array för alla dagar i maj 



        public double[] TemperatureAnalyzer()
        {

            Random random = new Random();

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.Next(2, 20);//genererar tempraturer mellan 2 och 20 
            }
            
        }
        
    }
}
