using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Calculator App !");
                Console.WriteLine("Type in two numbers you wish to multiply");
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());

                int sum = firstNumber * secondNumber;
                Console.Write("The multiple of the two numbers is " + sum);
            }
            catch (FormatException)
            {
                Console.Write("Only number values are accepted !");

            }
        }
    }
}