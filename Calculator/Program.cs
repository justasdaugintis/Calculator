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






        public static void PerformOneCalculation()
        {

            bool op = true;
            Console.Clear();

            while (op)
            {
                Console.WriteLine("Please enter the operator: ");
                var operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "/" || operation == "*")
                {
                    op = false;

                    try
                    {
                        Console.WriteLine("How many numbers you want to " + operation + " ?");
                        int numberAmount = int.Parse(Console.ReadLine());
                        int[] numbers = new int[numberAmount];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                                Console.WriteLine("please enter numer " + (i + 1) + ":");
                            if(int.TryParse(Console.ReadLine(), out int answer))
                            {
                                numbers[i] = answer;
                            }
                            else
                            {
                                Console.WriteLine("Not a number !. Try again. ");
                                i = i - 1;
                                continue;
                            }

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
                           
                        }
                        Console.Write("The answer is: " + sum);
                        Console.ReadLine();
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You've entered a wrong operator. Try again.");
                }
               
            }
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