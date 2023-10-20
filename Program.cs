using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ApplicationMessage.welcomeMessage);
        while (true)
        {
            MenuOption option = GetMenuOption();
            int num1 = GetIntegerInput(ApplicationMessage.inputFirstNumber);
            int num2 = GetIntegerInput(ApplicationMessage.inputSecondNumber);
            Calculator calc = new Calculator(num1, num2);
            switch (option)
            {
                case MenuOption.Add:
                    ApplicationMessage.ShowCustomMessage("Your result: " + calc.Add());
                    break;
                case MenuOption.Subtract:
                    ApplicationMessage.ShowCustomMessage("Your result: " + calc.Subtract());
                    break;
                case MenuOption.Multiply:
                    ApplicationMessage.ShowCustomMessage("Your result: " + calc.Multiply());
                    break;
                case MenuOption.Divide:
                    ApplicationMessage.ShowCustomMessage("Your result: " + calc.Divide());
                    break;
            }
            Console.WriteLine(ApplicationMessage.confirmExitMessage);
            if (Console.ReadLine().Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(ApplicationMessage.exitMessage);
                break;
            }
        }
    }

    public static MenuOption GetMenuOption()
    {
        while (true)
        {
            Console.WriteLine(ApplicationMessage.menuOptionMessage);
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine(ApplicationMessage.nullMessage);
                continue;
            }
            if (Enum.TryParse<MenuOption>(input, out MenuOption option) && Enum.IsDefined(typeof(MenuOption), option))
            {
                return option;
            }
            Console.WriteLine(ApplicationMessage.validOptionMessage);
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
                Console.WriteLine(ApplicationMessage.nullMessage);
                continue;
            }

            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine(ApplicationMessage.validInputMessage);
                continue;
            }
            return result;

        }
    }
}
