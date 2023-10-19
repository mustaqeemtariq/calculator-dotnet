using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------------\n\n Welcome to Calculator \n\n--------------------------\n");
        while (true)
        {
            string option = GetMenuOption();
            int num1 = GetIntegerInput("Enter the first number: ");
            int num2 = GetIntegerInput("Enter the second number: ");
            Calculator calc = new Calculator(num1, num2);
            switch (option)
            {
                case "1":
                    Console.WriteLine("Your result: " + calc.add());
                    break;
                case "2":
                    Console.WriteLine("Your result: " + calc.subtract());
                    break;
                case "3":
                    Console.WriteLine("Your result: " + calc.multiply());
                    break;
                case "4":
                    Console.WriteLine("Your result: " + calc.divide());
                    break;
            }
            Console.Write("Do you want to perform another calculation. Press No to exit program: ");
            if (Console.ReadLine().Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }

    public static string GetMenuOption()
    {
        while (true)
        {
            Console.WriteLine("Select one of the following operations\n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is required");
                continue;
            }
            if (input == "1" || input == "2" || input == "3" || input == "4")
            {
                return input;
            }
            Console.WriteLine("Please enter a valid menu option.\n");
            continue;

        }
    }
    public static int GetIntegerInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is required");
                continue;
            }

            int result;
            if (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input - must be a valid integer");
                continue;
            }
            return result;

        }
    }
}
