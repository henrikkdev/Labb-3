﻿namespace Labb_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureCalculator calculator = new TemperatureCalculator();
            Console.WriteLine("***************************************************************************\n" +
                "Hello and welcome to the TemperatureCalculator!\n" +
                "***************************************************************************\n\n" +
                "Type 1 if you want to continue \n" +
                "Type 2 if you want to exit\n");
            Console.Write("Your input: ");
            string UserInputStart = Console.ReadLine();
            Console.WriteLine("\n***************************************************************************");

            bool mainmenu = true;
            bool casemenu1 = true;
            bool casemenu2 = true;
            while (mainmenu == true)
            {
                try
                {

                    switch (UserInputStart)
                    {
                        case "1":
                            Console.Clear();//rensa consolen  
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

                            string UserInputMainMenu = Console.ReadLine();

                            while (casemenu1 == true)
                            {
                                switch (UserInputMainMenu)
                                {

                                    case "1": //lista
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
                                                return;
                                                
                                            }

                                            else if (UserInputswitch1 == "2")
                                            {
                                                //Sortera från kallt till varmt
                                                calculator.PrintTempSorter(false);
                                                casemenu2 = true;
                                            }

                                            else if (UserInputswitch1 == "3")
                                            {
                                                //Tillbaka till huvudmenyn
                                                mainmenu = true;
                                                return;
                                            }

                                            else if (UserInputswitch1 == "4")
                                            {
                                                //Avsluta programmet
                                                return;
                                            }

                                            else
                                            {
                                                Console.WriteLine("Invalid input");
                                            }

                                        }
                                        break;

                                }
                            }

                                while (casemenu2 == true)
                                {



                                    case "2":
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Type 1 if you want to see the average temperature\n" +
                                            "Type 2 if you want to see the median value\n" +
                                            "Type 3 if you want to return to the main menu\n" +
                                            "Type 4 if you want to exit");
                                        //Se Medel eller medianvärde på temperaturerna
                                        string userInput = Console.ReadLine();
                                        switch (userInput)
                                        {
                                            case "1":
                                                {
                                                    //Se Medelvärde
                                                    calculator.PrintAverageTemperature();
                                                    return;
                                                }
                                            case "2":
                                                {
                                                    //Se Medianvärde
                                                    calculator.PrintMedianTemp();
                                                    return;
                                                }
                                            case "3":
                                                {
                                                    //Återgå till menyn
                                                    mainmenu = true;
                                                    return;
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
                                }
                            }

                        case "3":
                            {


                                calculator.GetMaxTemp();
                                calculator.GetMinTemperature();
                                return;
                            }

                        case "4":
                            {

                                //tröskel lägg in user inp
                                calculator.Tempfilter(15);

                                return;
                            }


                        case "5":
                            {
                                //Visa dagens datum samt dagen innan och dagen efter, och printa temperatur lägg in user inp
                                Console.WriteLine("");

                                calculator.GetTemperatureOfDay(15);
                                return;
                            }

                        case "6":
                            {
                                //Visa vanligast förekommande temperatur

                                calculator.GetMostFrequentTemperature();
                                return;
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


                catch (Exception ex)
                {
                    Console.WriteLine("You are beeing redirected to the main menu.");
                }
            }
        }

    }
}
