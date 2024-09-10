using System;


namespace MathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();


                if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                try
                {
                    Console.WriteLine("Enter the first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int res = 0;

                    bool validOperation = true;


                    switch (choice)
                    {
                        case "1":
                            res = num1 + num2;
                            Console.WriteLine("Addition: " + res);
                            break;
                        case "2":
                            res = num1 - num2;
                            Console.WriteLine("Subtraction: " + res);
                            break;
                        case "3":
                            res = num1 * num2;
                            Console.WriteLine("Multiplication: " + res);
                            break;
                        case "4":
                            if (num2 != 0)
                            {
                                res = num1 / num2;
                                Console.WriteLine("Division: " + res);
                            }
                            else
                            {
                                Console.WriteLine("Error! Division by 0 is not allowed");
                            }
                            break;
                        default:
                            Console.WriteLine("Error: Invalid choice. Please select a valid option.");
                            validOperation = false;
                            break;
                    }

                    if (validOperation)
                    {
                        Console.Write("Do you want to continue(y/n):");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        value = "y";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: Please enter valid numbers.");
                    value = "y"; // Retry in case of error
                }

            }
            while (value == "y" || value == "Y");
        }
    }
}