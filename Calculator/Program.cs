using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the calculator !");
                Console.WriteLine("===========================");
                Console.WriteLine("Please enter the operator: ");
                var operation = Console.ReadLine();

                Console.WriteLine("Please enter the first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                int sum = 0;

                if (operation == "+")
                    sum = firstNumber + secondNumber;
                
                else if(operation == "-" )
                    sum = firstNumber - secondNumber;
                
                else if(operation == "*")
                    sum = firstNumber * secondNumber;

                else if(operation == "/")
                    sum = firstNumber / secondNumber;
                else
                    Console.WriteLine("Something went wrong"); 
                
                Console.Write("The answer is: " + sum);

            }
            catch (FormatException)
            {
                Console.Write("Only number values are accepted !");

            }
        }
    }
}