namespace Labb_3
{
    class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************\n" +
     "Hello and welcome to the TemperatureCalculator!\n" +
     "***************************************************************************\n\n");
            bool bExit = false;

            TemperatureCalculator calculator = new TemperatureCalculator();
            while (bExit == false)
            {

                Console.WriteLine("Type 1 if you want to continue \n" +
                    "Type 2 if you want to exit\n");
                Console.Write("Your input: ");
                string UserInputStart = Console.ReadLine();
                Console.WriteLine("\n***************************************************************************");

                switch (UserInputStart)
                {
                    case "1":
                        {
                            Console.Clear();//rensa consolen  
                            Console.Write($"***************************************************************************\n" +
                                $"Choose an option from the menu:\n" +
                                $"1. Display temperatures for all days\n" +
                                $"2. Display average and median values\n" +
                                $"3. Find the hottest and coldest day (including date)\n" +
                                $"4. Show days when the temperature exceeds a threshold\n" +
                                $"5. Show specific day's temperature as well as the day before and after\n" +
                                $"6. Show the most frequently occurring temperature in May\n" +
                                $"7. Exit the program\n" +
                                $"***************************************************************************\n" +
                                $"Put your input here:");

                            string UserInputMainMenu = Console.ReadLine();
                            switch (UserInputMainMenu)//huvudmeny switch
                            {
                                case "1"://lista
                                    {
                                        Console.Clear();
                                        calculator.Printdateandtemp();
                                        Console.WriteLine("These are the temperatures in May\n" +
                                            "1. Sort it from warmest to coldest\n" +
                                            "2. Sort it from coldest to warmest\n" +
                                            "3. Return to main menu\n" +
                                            "4. Exit ");

                                        string UserInputswitch1 = Console.ReadLine();
                                        if (UserInputswitch1 == "1")
                                        {
                                            //Sortera från varmt till kallt
                                            calculator.PrintTempSorter(true);

                                        }

                                        else if (UserInputswitch1 == "2")//kallt till varmt
                                        {
                                            calculator.PrintTempSorter(false);
                                        }

                                        else if (UserInputswitch1 == "3")//tilbaka till starten 
                                        {

                                        }

                                        else if (UserInputswitch1 == "4")//exit
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                                            bExit = true;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }

                                case "2"://avg temp och median
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1. average temperature\n" +
                                            "2. median value\n" +
                                            "3. return to the main menu\n" +
                                            "4. exit");

                                        string UserInputCase2 = Console.ReadLine();
                                        if (UserInputCase2 == "1")//average temp
                                        {
                                            calculator.PrintAverageTemperature();
                                        }
                                        
                                        else if(UserInputCase2 == "2")//median
                                        {
                                            calculator.PrintMedianTemp();
                                        }
                                        
                                        else if(UserInputCase2 == "3")//return
                                        {

                                        }
                                        
                                        else if(UserInputCase2 == "4")//exit
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                                            bExit = true;
                                            break;
                                        }
                                       
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        
                                        break;
                                    }
                                
                                case "3"://hottest/coldestday
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1. Hottestday\n" +
                                            "2. coldestday\n" +
                                            "3. return to the main menu\n" +
                                            "4. exit");
                                        
                                        string UserInputCase3 = Console.ReadLine();
                                        if (UserInputCase3 == "1")
                                        {
                                            calculator.GetMaxTemp();
                                        }
                                        else if (UserInputCase3 == "2")
                                        {
                                            calculator.GetMinTemperature();
                                        }
                                        
                                        else if (UserInputCase3 == "3")//return
                                        {

                                        }

                                        else if (UserInputCase3 == "4")//exit
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }
                                case "4"://tröskel
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1. Thresholdtemp\n" +
                                            "2. return to the main menu\n" +
                                            "3. exit");
                                        Console.Write("Your input:");
                                        string UserInputCase4 = Console.ReadLine();
                                        if (UserInputCase4 == "1")
                                        {
                                            Console.WriteLine("Enter a Temperature threshold");
                                            Console.Write("Your input:");
                                            string ThresholdInput = Console.ReadLine();
                                            if(double.TryParse(ThresholdInput, out double threshold))

                                            calculator.Tempfilter(threshold);
                                        }

                                        else if (UserInputCase4 == "2")//return
                                        {

                                        }

                                        else if (UserInputCase4 == "3")//exit
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }
                                case "5"://spesefik dag +dagen innan och efter
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1. specific day\n" +
                                            "2. return to the main menu\n" +
                                            "3. exit");
                                        Console.Write("Your input:");
                                        string UserInputCase5 = Console.ReadLine();
                                        if (UserInputCase5 == "1")
                                        {
                                            Console.WriteLine("Enter a day in may (1-31)");
                                            Console.Write("Your input:");
                                            string DayInput = Console.ReadLine();
                                            if (int.TryParse(DayInput, out int day))

                                                calculator.GetTemperatureOfDay(day);
                                        }

                                        else if (UserInputCase5 == "2")//return
                                        {

                                        }

                                        else if (UserInputCase5 == "3")//exit
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }
                                case "6"://mest fekventa graden 
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1. Most frequent temperature\n" +
                                            "2. return to the main menu\n" +
                                            "3. exit");
                                        Console.Write("Your input:");
                                        string UserInputCase6 = Console.ReadLine();
                                        if (UserInputCase6 == "1")
                                        {
                                            calculator.GetMostFrequentTemperature();
                                        }

                                        else if (UserInputCase6 == "2")//return
                                        {

                                        }

                                        else if (UserInputCase6 == "3")//exit
                                        {
                                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                                            bExit = true;
                                            break;
                                        }

                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                        }
                                        break;
                                    }
                                case "7":
                                    {
                                        Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                                        bExit = true;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid input");
                                        break;
                                    }
                            }
                            break;
                        }



                    case "2": //Avslut
                        {
                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n" +
                                "***************************************************************************");
                            bExit = true;
                            break;
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