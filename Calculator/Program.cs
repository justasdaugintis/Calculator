using System;

namespace Calculator
{
    class MainClass
    {
       

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator !");
            Console.WriteLine("===========================");
        }

        public static  void PerformOneCalculation()
        {
            

                Console.Clear();
                Console.WriteLine("Please enter the operator: ");
                var operation = Console.ReadLine();
                Console.WriteLine("How many numbers you want to " + operation + " ?");
                int numberAmount = int.Parse(Console.ReadLine());
                int[] numbers = new int[numberAmount];
                

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("please enter numer " + (i + 1) + ":");
                    numbers[i] = int.Parse(Console.ReadLine());

                }

               int sum = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (operation == "+")
                    {
                        sum = sum + numbers[i];
                    //return true;
                    }

                    else if (operation == "-")
                    {
                        sum = sum - numbers[i];
                   // return true;
                    }

                    else if (operation == "*")
                    {
                        sum = sum * numbers[i];
                   // return true;
                    }


                    else if (operation == "/")
                    {
                        sum = sum / numbers[i];
                   // return true;
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                   // return true;
                    }
                }

                //Print out answer
                Console.Write("The answer is: " + sum);
                 Console.ReadLine();
           // return true;

        }


        public static void Main(string[] args)
        {
            bool keepGoing = true;
            PrintWelcomeMessage();

            while (keepGoing)
            {
           PerformOneCalculation();
            }
          

           Console.ReadLine();
           
        }
    }
}