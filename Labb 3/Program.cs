namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************\nHello and welcome to the TemperatureCalculator!");

            while (true) {

                Console.WriteLine("***************************************************************************\n\nType 1 if you want to continiue \nType 2 if you want to exit\n");
                Console.Write("Your input: ");
                string UserInput = Console.ReadLine();
                Console.WriteLine("\n***************************************************************************");

                switch (UserInput) {

                    
                    case "1": //Huvudkoden
                    {


                        break;
                    }


                    case "2": //Avslut
                    {
                        Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                        return;
                    }
                }

            }
        } 
        
    }
}
