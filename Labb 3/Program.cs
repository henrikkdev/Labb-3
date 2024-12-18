namespace Labb_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Välkomstmeddelande
            Console.WriteLine("***************************************************************************\n" +
                "Hello and welcome to the TemperatureCalculator!\n" +
                "***************************************************************************");

            //Instansiering av klassen TemperatureCalculator
            TemperatureCalculator calculator = new TemperatureCalculator();

            //Flagga för meny-loopen, samt while loop
            bool bExit = false;
            while (bExit == false)


            {
                //Startmeny och returmeny

                Console.WriteLine("***************************************************************************\n" +
                    "1. if you want to continue \n" +
                    "2. if you want to exit\n");
                Console.Write("Your input: ");
                string userInputStart = Console.ReadLine();
                Console.WriteLine("\n***************************************************************************");


                switch (userInputStart)
                {
                    //Huvudmeny
                    case "1":
                        {
                            Console.Write("Choose an option from the menu:\n" +
                                "1. Display temperatures for all days\n" +
                                "2. Display average and median values\n" +
                                "3. Find the hottest and coldest day (including date)\n" +
                                "4. Show days when the temperature exceeds a threshold\n" +
                                "5. Show specific day's temperature as well as the day before and after\n" +
                                "6. Show the most frequently occurring temperature in May\n" +
                                "7. Exit the program\n" +
                                "***************************************************************************\n" +
                                "Put your input here:");

                            string userInputMainMenu = Console.ReadLine();

                            //Undermeny med temperatursorterare
                            switch (userInputMainMenu)
                            {
                                case "1":
                                    {

                                        calculator.Printdateandtemp();
                                        Console.WriteLine("These are the temperatures in May\n" +
                                            "1. Sort it warmest --> coldest\n" +
                                            "2. Sort it coldest --> warmest\n" +
                                            "3. Return to main menu\n" +
                                            "4. Exit ");

                                        string userInputswitch1 = Console.ReadLine();

                                        //Sortera från varmt till kallt
                                        if (userInputswitch1 == "1")
                                        {
                                            calculator.PrintTempSorter(true);
                                        }

                                        //Kallt till varmt
                                        else if (userInputswitch1 == "2")
                                        {
                                            calculator.PrintTempSorter(false);
                                        }

                                        //Tillbaka till starten 
                                        else if (userInputswitch1 == "3")
                                        {
                                            continue;
                                        }

                                        //Exit
                                        else if (userInputswitch1 == "4")
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                                "***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        //Felinput
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }

                                //Undermeny med medeltemperatur och mediantemperatur
                                case "2":
                                    {
                                        Console.WriteLine("1. Average temperature\n" +
                                            "2. Median value\n" +
                                            "3. Return to the main menu\n" +
                                            "4. Exit");

                                        string userInputCase2 = Console.ReadLine();

                                        //Average temp
                                        if (userInputCase2 == "1")
                                        {
                                            calculator.PrintAverageTemperature();
                                        }

                                        //Median
                                        else if (userInputCase2 == "2")
                                        {
                                            calculator.PrintMedianTemp();
                                        }

                                        //Return
                                        else if (userInputCase2 == "3")
                                        {

                                        }

                                        //Exit
                                        else if (userInputCase2 == "4")
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                                "***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        //Felinput
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }

                                        break;
                                    }

                                //Undermeny för den varmaste och kallaste dagen
                                case "3":
                                    {

                                        Console.WriteLine("1. Hottest day\n" +
                                            "2. Coldest day\n" +
                                            "3. Return to the main menu\n" +
                                            "4. Exit");

                                        string userInputCase3 = Console.ReadLine();

                                        //Maxtemp
                                        if (userInputCase3 == "1")
                                        {
                                            calculator.GetMaxTemp();
                                        }

                                        //Lägsta temp
                                        else if (userInputCase3 == "2")
                                        {
                                            calculator.GetMinTemp();
                                        }

                                        //Return
                                        else if (userInputCase3 == "3")
                                        {

                                        }

                                        //Exit
                                        else if (userInputCase3 == "4")
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                                "***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        //Felinput
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }

                                //Undermeny med användarinmatning på ett tröskelvärde 
                                case "4":
                                    {
                                        Console.WriteLine("1. Type a threshold tempererature\n" +
                                            "2. Return to the main menu\n" +
                                            "3. Exit");
                                        Console.Write("Your input:");
                                        string userInputCase4 = Console.ReadLine();

                                        //Tröskel
                                        if (userInputCase4 == "1")
                                        {
                                            Console.WriteLine("Enter a Temperature threshold");
                                            Console.Write("Your input:");
                                            string ThresholdInput = Console.ReadLine();
                                            if (double.TryParse(ThresholdInput, out double threshold))

                                                calculator.Tempfilter(threshold);
                                        }

                                        //Return
                                        else if (userInputCase4 == "2")
                                        {
                                            continue;
                                        }

                                        //Exit
                                        else if (userInputCase4 == "3")
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                                "***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        //Felinput
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }

                                //Undermeny för specifik dag, samt dagen innan och efter
                                case "5":
                                    {

                                        Console.WriteLine("1. Type a specific day too see the temperature for that day\n" +
                                            "2. Return to the main menu\n" +
                                            "3. Exit");
                                        Console.Write("Your input:");
                                        string userInputCase5 = Console.ReadLine();

                                        //Specefikdag
                                        if (userInputCase5 == "1")
                                        {
                                            Console.WriteLine("Enter a day in may (1-31)");
                                            Console.Write("Your input:");
                                            string DayInput = Console.ReadLine();
                                            if (int.TryParse(DayInput, out int day))

                                                calculator.GetTempOfDay(day);
                                        }

                                        //Return
                                        else if (userInputCase5 == "2")
                                        {

                                        }

                                        //Exit
                                        else if (userInputCase5 == "3")
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                                "***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        //Felinput
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }

                                //Undermeny för den mest frekventa graderna
                                case "6":
                                    {

                                        Console.WriteLine("1. Most frequent temperature(s)\n" +
                                            "2. Return to the main menu\n" +
                                            "3. Exit");
                                        Console.Write("Your input:");
                                        string userInputCase6 = Console.ReadLine();

                                        //Mest frekventa graden på månade
                                        if (userInputCase6 == "1")
                                        {
                                            calculator.GetMostFrequentTemp();
                                        }

                                        //Return
                                        else if (userInputCase6 == "2")
                                        {

                                        }

                                        //Exit
                                        else if (userInputCase6 == "3")
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                                "***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        //Felinput
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }

                                //Avslutar programmet med hjälp av flaggan vi satte i början av while-loopen
                                case "7":
                                    {
                                        Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                            "***************************************************************************");
                                        bExit = true;
                                        break;
                                    }

                                //Felinput
                                default:
                                    {
                                        Console.WriteLine("Invalid input");
                                        break;
                                    }
                            }
                            break;
                        }


                    //Avslutar programmet
                    case "2":
                        {
                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                "***************************************************************************");
                            bExit = true;
                            break;
                        }

                    //Felinput
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