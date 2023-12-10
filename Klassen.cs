using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Program;



namespace CalculatorKlassen
{
    internal class Menu
    {
        
        public static void PrintMenu(bool clear = true)
        {
            //Clearing the console
            if (clear)
                Console.Clear();
            
            // Displaying Calculator Menu
            Console.WriteLine("Calculator Menu");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplacation");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Exit");


          

        }
    }

    class Operation : Functions
    {
        
        public static void Division()
        {
            
            //Defining Division
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumberExludingZero("Please enter your second number");

            double result = firstNumber * 1.0 / secondNumber;
            Console.WriteLine(result);
        }

        public static void Multiplacation()
        {
            //Defining Multiplacation
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumber("Please enter your second number");

            double result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        public static void Subtraction()
        {
            //Defining Subtraction
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumber("Please enter your second number");

            double result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        public static void Addition()
        {
            //Defining Addition
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumber("Please enter your second number");

            double result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }




    }

    class Functions
    {
        public static int ReadNumber(string prompt)
        {
            //IsValid is a bool that is true or false
            bool isValid;
            int result;
            do
            {
                //Prompting the user to enter a number
                Console.WriteLine(prompt);
                string input = Console.ReadLine()!;
                isValid = int.TryParse(input, out result);
                if (!isValid)
                {
                    //If the user enters a letter, the program will display an error message and prompt the user to enter a number
                    Console.WriteLine("Invalid input. Please enter a number");
                }
            } while (!isValid);

            return result;
        }

        public static int ReadNumberExludingZero(string prompt)
        {
            //IsValid is a bool that is true or false
            bool isValid;
            int result;
            do
            {
                // Prompting the user to enter a number other than zero                
                Console.WriteLine(prompt);
                string input = Console.ReadLine()!;
                isValid = int.TryParse(input, out result);
                if (!isValid || result == 0)
                {
                    //If the user enters zero, the program will display an error message and prompt the user to enter a number other than zero
                    Console.WriteLine("Invalid input. Please enter a number that is not Zero");
                }
            } while (!isValid || result == 0);

            return result;
        }
    }   
}




