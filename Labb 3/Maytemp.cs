using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{
    internal class Maytemp
    {
        internal class TemperatureCalculator
        {
            //privata fält
            private string mayTemperature;

            //konstruktor
            public TemperatureCalculator(string mayTemperature)
            {
                this.mayTemperature = mayTemperature;

                GenerateTemperature();
            }

            //Metod för att skapa random temp
            private void GenerateTemperature()
            {
                Random random = new Random();
                string mayTemperature = random.Next(2, 20).ToString();
                mayTemperature = mayTemperature.ToUpper();
                this.mayTemperature = mayTemperature;
            }

            //Metod för att hämta temperatur
            public string GenerateMayTemperature()
            {
                GenerateTemperature();
                return $"{mayTemperature}";
            }
        }
    }
}

