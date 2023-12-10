
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorKlassen.Operation;
using static CalculatorKlassen.Menu;




namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool isDone = false;
            
            
            PrintMenu (false);
            { 
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


       
        public static int ReadNumber(string prompt)
        {
            bool isValid;
            int Result;
            

            do
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine()!;
                isValid = int.TryParse(userInput, out Result);


                if (!isValid)
                {
                    //Display for the stupid
                    Console.WriteLine("Please enter a Number!");
                    Console.ReadKey(true);
                    continue;
                    //Do stuff while it is not valid
                }  //Negated is valid


            }
            while (!isValid);

            return Result;


        }


        public static int ReadNumberExludingZero(string prompt)
        {
            int number;
            
            do
            {

                number = ReadNumber(prompt);


                if (number == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    Console.ReadKey(true);

                }
            } 
            while (number == 0);

            return number;
        }

       

               
             
            
      
       
            
    }   
}
