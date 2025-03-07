using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.WriteLine("Calculation Mode: Activated");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter in a number.");

                string input1 = Console.ReadLine();
                int num1;
                bool validInput1 = false;

                while (!validInput1)
                {
                    if (int.TryParse(input1, out num1))
                    {
                        Console.WriteLine("You have entered: " + num1);
                        validInput1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }
                Console.WriteLine("Enter in another number");

                string input2 = Console.ReadLine();
                int num2;
                bool validInput2 = false;

                while (!validInput2)
                {
                    if (!int.TryParse(input2, out num2))
                    {
                        Console.WriteLine("You have entered: " + num2);
                        validInput2 = true;
                    }    
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }

                Console.WriteLine("Please enter in a function.");
                Console.WriteLine("\t1. Add");
                Console.WriteLine("\t2. Subtract");
                Console.WriteLine("\t3. Multiply");
                Console.WriteLine("\t4. Divide");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The sum is " + Add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("The difference is " + Subtract(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("The product is " + Multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("The quotient is " + Divide(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Please input a valid number");
                        break;
                }



            }
        static int Add(int num1, int num2)
            {
                return num1 + num2;
            }
        static int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }
        static int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }
        static int Divide(int num1, int num2)
            {
                return num1 / num2;
            }
        }
    }
}
