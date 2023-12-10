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

    class Operation
    {
        public static void Division()
        {
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumberExludingZero("Please enter your second number");

            double result = firstNumber * 1.0 / secondNumber;
            Console.WriteLine(result);
        }

        public static void Multiplacation()
        {
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumber("Please enter your second number");

            double result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        public static void Subtraction()
        {
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumber("Please enter your second number");

            double result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        public static void Addition()
        {
            var firstNumber = ReadNumber("Please enter your first number");
            var secondNumber = ReadNumber("Please enter your second number");

            double result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }




    }

}


