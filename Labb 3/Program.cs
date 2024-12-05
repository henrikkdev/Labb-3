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
                string UserInputStart = Console.ReadLine();
                Console.WriteLine("\n***************************************************************************");

                switch (UserInputStart) {

                    
                    case "1": //Huvudkoden
                    {
                            Console.WriteLine("***************************************************************************\n\nType 1 if you want to continiue \nType 2 if you want to exit\n");

                            switch (UserInputMain)
                            {
                                case "1": { }
                                
                                case "2": { }

                                case "3": { }

                                case "4": { }

                                case "5": { }

                                case "6": { }

                                case "7": { }
                            }
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
