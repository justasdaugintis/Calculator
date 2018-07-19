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

                // create an array of numbers
                Console.WriteLine("How many numbets you want to " + operation + " ?");
                int numberAmount = int.Parse(Console.ReadLine());
                int[] numbers= new int[numberAmount];
                int sum = 0;

                // loop through each array item and give it value, then perform operations on those numbers.

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("please enter numer " + (i + 1) + ":");
                    numbers[i] = int.Parse(Console.ReadLine());
                   
                }
                sum = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (operation == "+")
                        sum = sum + numbers[i];

                    else if (operation == "-")
                        sum = sum - numbers[i];

                    else if (operation == "*")
                        sum = sum * numbers[i];

                    else if (operation == "/")
                        sum = sum / numbers[i];
                    else
                        Console.WriteLine("Something went wrong");
                }

                //Print out answer
                Console.Write("The answer is: " + sum);

            }
            catch (FormatException)
            {
                Console.Write("Only number values are accepted !");

            }
        }
    }
}