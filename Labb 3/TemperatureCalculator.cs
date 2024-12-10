using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{ 
     class TempertureAnalyzer
     {
         //array för varje dag i maj
         private static double[] temperatures = new double[31];
    
         public TempertureAnalyzer()
         {
             Random random = new Random();
    
             for (int i = 0; i < temperatures.Length; i++)
             {
                 temperatures[i] = random.Next(5, 20);
             }
         }
         public void Pintdateandtemp()
         {
             //printar värmen för varje dag 
             for (int i = 0; i < temperatures.Length; i++)
             {
                 Console.WriteLine($"day {i + 1}: {temperatures[i]}°C");
             }
         }


     }
}
