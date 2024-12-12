namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureCalculator calculator = new TemperatureCalculator();

            Console.WriteLine("***************************************************************************\n" +
                "Hello and welcome to the TemperatureCalculator!");

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

                                                switch (UserInputCase1)
                                                {
                                                    case "1":
                                                        {
                                                            Console.WriteLine("These are the temperatures in May\n" +
                                                                "1. Sort it from warmest to coldest\n" +
                                                                "2. Sort it from coldest to warmest\n" +
                                                                "3. Return to main menu\n" +
                                                                "4. Exit ");
                                                            string UserInputswitch1 = Console.ReadLine();
                                                            switch (UserInputswitch1)
                                                            {
                                                                case "1":
                                                                    {
                                                                        //Sortera från varmt till kallt
                                                                        calculator.PrintTempSorter(true);
                                                                        break;
                                                                    }
                                                                case "2":
                                                                    {
                                                                        //Sortera från kallt till varmt
                                                                        calculator.PrintTempSorter(false);
                                                                        break;
                                                                    }
                                                                case "3":
                                                                    {
                                                                        //Tillbaka till huvudmenyn
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        //Avsluta programmet

                                                                        return;
                                                                    }
                                                            }

                                                            break;
                                                        }

                                                    case "2":
                                                        {
                                                            //Se Medel eller medianvärde på temperaturerna
                                                            string userInput = Console.ReadLine();
                                                            switch (userInput)
                                                            {
                                                                case "1":
                                                                    {
                                                                        //Se Medelvärde
                                                                        break;
                                                                    }
                                                                case "2":
                                                                    {
                                                                        //Se Medianvärde
                                                                        break;
                                                                    }
                                                                case "3":
                                                                    {
                                                                        //Återgå till menyn
                                                                        break;
                                                                    }
                                                                case "4":
                                                                    {
                                                                        //Avsluta programmet
                                                                        break;
                                                                    }
                                                                default:
                                                                    {

                                                                        break;
                                                                    }
                                                            }

                                                            break;
                                                        }

                                                    case "3":
                                                        {
                                                            calculator.Printdateandtemp();
                                                            return;
                                                        }

                                                    case "4":
                                                        {

                                                            Console.WriteLine("You will now return to the main menu");

                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Your input was invalid try again but with nmbr\n");
                                                            return; //går tillbaka till menyn om input är fel
                                                        }


                                                }
                                                break;
                                            }

                                        case "2": // Lista. Alternativ att se medelvärde och medianvärde
                                            {
                                                // Console.WriteLine($"Medeltemp: {analyzer.GetAverageTemperature()}");
                                                calculator.PrintTempSorter(false);

                                                break;
                                            }

                                        case "3":
                                            {
                                                // Se den varmaste och kallaste dagen
                                                Console.WriteLine("");
                                                break;
                                            }

                                        case "4":
                                            {
                                                //Visa när der är varmare än ett visst tröskelvärde
                                                Console.WriteLine("");
                                                break;
                                            }

                                        case "5":
                                            {
                                                //Visa dagens datum samt dagen innan och dagen efter, och printa temperatur
                                                calculator.GetTemperatureOfDay(15);
                                                break;
                                            }

                                        case "6":
                                            {
                                                //Visa vanligast förekommande temperatur
                                                calculator.GetMostFrequentTemperature();
                                                break;
                                            }

                                        case "7":
                                            {
                                                // Avsluta programmet
                                                Console.WriteLine("\n***************************************************************************\n" +
                                                    "Thank you for using this program, hope to see you again soon" +
                                                    "\n***************************************************************************");
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
                                Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                    "***************************************************************************");
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
}
