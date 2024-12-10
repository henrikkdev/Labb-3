namespace Labb_3
{
    internal class Maytemp
    {


        //privata fält
        private static double[] mayTemperature = new double[30];

        //konstruktor
        //    public Maytemp(string mayTemperature)
        //{
        //    this.mayTemperature = mayTemperature;

        //    GenerateTemperature();
        //}

        //Metod för att skapa random temp
        public Maytemp()
        {
            /* Random random = new Random();
             string mayTemperature = random.Next(2, 20).ToString();
             mayTemperature = mayTemperature.ToUpper();
             this.mayTemperature = mayTemperature;
            */
            Random random = new Random();
            for (int i = 0; i < mayTemperature.Length; i++)
            {
                mayTemperature[i] = random.Next(2, 20);
            }

        }

        //Metod för att hämta temperatur
        public void GenerateMayTemperature()
        {

            for (int i = 0; i < mayTemperature.Length; i++)
            {
                Console.WriteLine($"Dag {i + 1}: {mayTemperature[i]}°C");
            }


        }
    }
}


