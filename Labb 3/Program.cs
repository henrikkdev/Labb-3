namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************\nHello and welcome to the TemperatureCalculator!");

            while (true)
            {

                Console.WriteLine("***************************************************************************\n\n" +
                    "Type 1 if you want to continue \n" +
                    "Type 2 if you want to exit\n");
                Console.Write("Your input: ");
                string UserInputStart = Console.ReadLine();
                Console.WriteLine("\n***************************************************************************");
                while (true)  
            {
                switch (UserInputStart)
                {
                    case "1":
                        Console.Clear();//rensa consolen  

                        while (true)
                        {
                            {
                                Console.Clear();
                                Console.Write($"***************************************************************************\n" +
                                    $"Choose an option from the menu:\n" +
                                    $"1. Display temperatures for all days\n" +
                                    $"2. Display average and median values\n" +
                                    $"3. Find the hottest and coldest day (including date)\n" +
                                    $"4. Show days when the temperature exceeds a threshold\n" +
                                    $"5. Show today's temperature as well as the day before and after\n" +
                                    $"6. Show the most frequently occurring temperature in May\n" +
                                    $"7. Exit the program\n" +
                                    $"***************************************************************************\n" +
                                    $"Put your input here:");
                                string UserInputMain = Console.ReadLine();

                                switch (UserInputMain)
                                {
                                    case "1": //lista
                                        {
                                            Console.Clear();
                                            Console.WriteLine("***************************************************************************\n" +
                                                "You chose to view the temperature for each day in a list.\n" +
                                                "Now you will get three options for how you want to see this list:\n" +
                                                "1. Date\n" +
                                                "2. Warmest to coldest\n" +
                                                "3. Coldest to warmest\n" +
                                                "4. Exit");
                                            string UserInputCase1 = Console.ReadLine();


                                            bool returnToMainMenu = false;
                                            while (!returnToMainMenu)
                                            {
                                                switch (UserInputCase1)
                                                {
                                                    case "1":
                                                        {
                                                            TemperatureCalculator Tmpcalc = new TemperatureCalculator();
                                                            string templist = Tmpcalc.TemperatureList();
                                                            Console.WriteLine(templist.ToString());
                                                            return;
                                                        }

                                                    case "2":
                                                        {

                                                            // Här ska vi ha ett alternativ att kunna se koden i 
                                                            Maytemp tempCalculator = new Maytemp();
                                                            tempCalculator.GenerateMayTemperature();
                                                            return;
                                                        }

                                            case "3":
                                            {
                                                Console.Clear();
                                                TemperatureCalculator Tmpcalc = new TemperatureCalculator();
                                                            double[] templist = Tmpcalc.TemperatureAnalyzer();
                                                            var sortedTemps = templist.OrderByDescending(t => t).ToArray();
                                                            for (int i = 0;i < sortedTemps.Length; i++)
                                                            {
                                                            Console.WriteLine($"Day {i + 1}: {sortedTemps[i]}°C"); 
                                                            }
                                                            
                                                return;
                                            }
                                            
                                            case "4": 
                                            {
                                                Console.WriteLine("You will now return to the main menu");
                                                returnToMainMenu=true; 
                                                break;          
                                            }
                                            
                                            default:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Your input was invalid try again but with nmbr\n");
                                                return; //går tillbaka till menyn om input är fel
                                            }
                                              
                                           
                                        }
                                    }
                                break;//Breakar main 
                                }

                               /* case "2": // Lista. Alternativ att se medelvärde och medianvärde
                                {
                                Console.WriteLine($"Medeltemp: {analyzer.GetAverageTemperature()}");
                                break;
                                }*/

                                    case "3":
                                        {
                                            Console.WriteLine("");
                                            break;
                                        }

                                    case "4":
                                        {
                                            Console.WriteLine("");
                                            break;
                                        }

                                    case "5":
                                        {
                                            Console.WriteLine("");
                                            break;
                                        }

                                    case "6":
                                        {
                                            Console.WriteLine("");
                                            break;
                                        }

                                    case "7":
                                        {
                                            Console.WriteLine("\n***************************************************************************\nThank you for using this program, hope to see you again soon\n***************************************************************************");
                                            return; //avslutar huvudmenyn
                                        }

                                    default:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Your input was invalid try again but with nmbr\n");
                                            break; //går tillbaka till huvudmenyn om input är fel
                                        }

                                }
                            }
                        }

                    case "2": //Avslut
                        {
                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Your input was invalid try again but with nmbr");
                            break;
                        }
                }

            }
        }

    }
}
