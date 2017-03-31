using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Factorial Calculator! Enter an integer between 1 and 10.");
                int startNum = int.Parse(Console.ReadLine());
                if (startNum > 0 && startNum <= 10)
                {
                    Console.WriteLine("The Factorial of " + startNum + " is " + Factorial(startNum));
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please enter a number between 1 and 10.");
                }
                run = Continue();
            }
        }
         public static int Factorial(int startNum)
        {
            int answer =1;
            for (int i = startNum; i > 0; i--)
            {
                answer = answer * i;
            }
            return answer;
        }
            public static Boolean Continue()
        {
            Console.WriteLine("Continue? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}
