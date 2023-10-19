public static class ApplicationMessage
{
    public static void ShowWelcomeMessage()
    {
        Console.WriteLine("--------------------------\n\n Welcome to Calculator \n\n--------------------------\n");
    }

    public static void ShowExitMessage()
    {
        Console.WriteLine("Goodbye!");
    }

    public static void ShowMenuOptionMessage()
    {
        Console.WriteLine("Select one of the following operations\n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
    }

    public static void ShowNullMessage()
    {
        Console.WriteLine("Input is required");
    }

    public static void ShowValidOptionMessage()
    {
        Console.WriteLine("Please enter a valid menu option.\n");
    }

    public static void ShowValidInputMessage()
    {
        Console.WriteLine("Invalid input - must be a valid integer");
    }

    public static void ShowConfirmExitMessage()
    {
        Console.Write("Do you want to perform another calculation. Press No to exit program: ");
    }

    public static void ShowCustomMessage(string message)
    {
        Console.WriteLine(message);
    }
}