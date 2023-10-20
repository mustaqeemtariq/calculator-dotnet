using System;

enum MenuOption
{
    Add = 1,
    Subtract = 2,
    Multiply = 3,
    Divide = 4
}
class Program
{
    static void Main()
    {
        ApplicationMessage.ShowWelcomeMessage();
        while (true)
        {
            MenuOption option = GetMenuOption();
            int num1 = GetIntegerInput("Enter the first number: ");
            int num2 = GetIntegerInput("Enter the second number: ");
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
            ApplicationMessage.ShowConfirmExitMessage();
            if (Console.ReadLine().Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                ApplicationMessage.ShowExitMessage();
                break;
            }
        }
    }

    public static MenuOption GetMenuOption()
    {
        while (true)
        {
            ApplicationMessage.ShowMenuOptionMessage();
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                ApplicationMessage.ShowNullMessage();
                continue;
            }
            if (Enum.TryParse<MenuOption>(input, out MenuOption option) && Enum.IsDefined(typeof(MenuOption), option))
            {
                return option;
            }
            ApplicationMessage.ShowValidOptionMessage();
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
                ApplicationMessage.ShowNullMessage();
                continue;
            }

            if (!int.TryParse(input, out int result))
            {
                ApplicationMessage.ShowValidInputMessage();
                continue;
            }
            return result;

        }
    }
}
