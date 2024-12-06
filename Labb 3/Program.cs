﻿namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           TemperatureCalculator tempCalculator = new TemperatureCalculator("13");
           string temperature = tempCalculator.GenerateMayTemperature();
           Console.WriteLine(temperature);
           Console.ReadLine();
            
            Console.WriteLine("***************************************************************************\nHello and welcome to the TemperatureCalculator!");

            while (true)  
            {

                Console.WriteLine("***************************************************************************\n\nType 1 if you want to continiue \nType 2 if you want to exit\n");
                Console.Write("Your input: ");
                string UserInputStart = Console.ReadLine();
                Console.WriteLine("\n***************************************************************************");

                switch (UserInputStart)
                {
                    case "1":
                        Console.Clear();//rensa consolen  

                        while (true) 
                        {
                            {
                                Console.Clear();
                                Console.Write($"***************************************************************************\nChoose an option from the menu:\n1. Display temperatures for all days\n2. Display average and median values\n3. Find the hottest and coldest day (including date)\n4. Show days when the temperature exceeds a threshold\n5. Show today's temperature as well as the day before and after\n6. Show the most frequently occurring temperature in May\n7. Exit the program\n***************************************************************************\nPut your input here:");
                                string UserInputMain = Console.ReadLine();

                            switch (UserInputMain)
                            {
                                case "1": //lista
                                {
                                    Console.Clear();
                                    Console.WriteLine("***************************************************************************\nYou chose to view the temperature for each day in a list.\nNow you will get three options for how you want to see this list:\n1. Date\n2. Warmest to coldest\n3. Coldest to warmest\n4. Exit");
                                    string UserInputCase1 = Console.ReadLine();
                                    
                                    bool returnToMainMenu = false;
                                    while (!returnToMainMenu) 
                                    {
                                        switch (UserInputCase1)
                                        {
                                            case "1":
                                            {
                                                Console.WriteLine();
                                                break;
                                            }
                                            
                                            case "2":
                                            {
                                                Console.WriteLine();
                                                break;
                                            }

                                            case "3":
                                            {
                                                Console.WriteLine();
                                                return;
                                            }
                                            
                                            case "4": 
                                            {
                                                Console.WriteLine("You will now return to mainmenu");
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

                                /*case "2": // Lista. Alternativ att se medelvärde och medianvärde
                                    {
                                    switch()
                                       Console.WriteLine("");
                                    
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
