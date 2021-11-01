using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int intNum1, intNum2;
            string operation;

            try
            {
                Console.WriteLine("Enter first number: ");
                while (!int.TryParse(Console.ReadLine(), out intNum1))
                    Console.WriteLine("Input must be a variable. Try again");
                Console.WriteLine("Enter second number: ");
                while (!int.TryParse(Console.ReadLine(), out intNum2))
                    Console.WriteLine("Input must be a variable. Try again");
                Console.WriteLine("Desired operation? Add, Subtract, Multiply, or Divide: ");
                operation = Console.ReadLine();
                operation = operation.ToUpper();
                if (operation == "ADD")
                {
                    AddNumbers(intNum1, intNum2);
                }
                else if (operation == "SUBTRACT")
                {
                    SubtractNumbers(intNum1, intNum2);
                }
                else if (operation == "MULTIPLY")
                {
                    MultiplyNumbers(intNum1, intNum2);
                }
                else if (operation == "DIVIDE")
                {
                    DivideNumbers(intNum1, intNum2);
                }
                else
                {
                    Console.WriteLine($"The operation \"{operation}\" was not understood, please try again. Please use \"Add\", \"Subtract\", \"Multiply\", or \"Divide\".");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The application has encountered a problem and will now shut down.");
            }
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }
        }
        static int AddNumbers(int num1, int num2)
        {
            int Result = num1 + num2;
            Console.WriteLine(Result);
            return Result;
        }
        static int SubtractNumbers(int num1, int num2)
        {
            int Result = num1 - num2;
            Console.WriteLine(Result);
            return Result;
        }
        static int MultiplyNumbers(int num1, int num2)
        {
            int Result = num1 * num2;
            Console.WriteLine(Result);
            return Result;
        }
        static int DivideNumbers(int num1, int num2)
        {
            int Result = num1 / num2;
            Console.WriteLine(Result);
            return Result;
        }
    }
}
