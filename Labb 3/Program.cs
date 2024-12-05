﻿namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                        while (true) {
                        {
                            Console.Write($"***************************************************************************\nChoose an option from the menu:\n1. Display temperatures for all days\n2. Display average and median values\n3. Find the hottest and coldest day (including date)\n4. Show days when the temperature exceeds a threshold\n5. Show today's temperature as well as the day before and after\n6. Show the most frequently occurring temperature in May\n7. Exit the program\n***************************************************************************\nPut your input here:");
                            string UserInputMain = Console.ReadLine();

                                switch (UserInputMain)
                                {
                                    case "1":
                                    {
                                        Console.WriteLine("");
                                        break;
                                    }

                                    case "2":
                                    {
                                        Console.WriteLine("");
                                        break;
                                    }

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
