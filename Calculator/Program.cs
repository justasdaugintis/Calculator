using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class MainClass
    {
       

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator !");
            Console.WriteLine("===========================");
        }

        // check for operator
        public static string Operator()
        {
            Console.WriteLine("Please enter the operator: ");
            var operation = Console.ReadLine();
            return operation;
        }

        // create an array
        public static int[] NumberArray(string operation)
        {
            var amount = NumberCheck("How many numbers do you want to " + operation + "? ");
            int[] numbers = new int[amount];
  
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = NumberCheck("please enter numer " + (i + 1) + ":");
            }
            return numbers;
        }

        //check if a number is valid
        public static int NumberCheck(string message)
        {
            int answer;
            do
            {
              Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out answer));

              return answer;

        }

        //perform a calculation
        public static int Calculate(string operation, int[] numbers)
        {
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
            return sum;
        }
                    
               
        public static void PerformOneCalculation()
        {
            var operation = Operator();
            var numbers = NumberArray(operation);
            var answer = Calculate(operation, numbers);

            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
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