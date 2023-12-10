
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorKlassen.Operation;
using static CalculatorKlassen.Menu;
using static CalculatorKlassen.Functions;




namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //IsDone is a bool that is set to false. It is used to determine if the program should continue running or not.
            //The program will continue running until the user enters 5, which is the exit option.
            bool isDone = false;
            
            
            PrintMenu (false);
            { 
                //This is the menu that is displayed to the user. It is displayed every time the user has completed a calculation.
                //The menu is displayed until the user enters 5, which is the exit option.
                //The menu is also displayed if the user enters an invalid choice.
                //The menu is displayed by calling the PrintMenu method from the Menu class.
                
                var Result = ReadNumber("Please enter your choice:");

                
                switch (Result)
                {
                    case 1:
                        Addition();
                        break;

                    case 2:
                        Subtraction();
                        break;

                    case 3:
                        Multiplacation();
                        break;

                    case 4:
                        Division();
                        break;

                    case 5:
                        isDone = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1-5");
                        break;
                        
                }
                

            }
            while (!isDone);
           

        }


       
       
                   
            
    }   
}

