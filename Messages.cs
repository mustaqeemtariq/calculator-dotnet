public static class ApplicationMessage
{
    static readonly string welcomeMessage = "--------------------------\n\n Welcome to Calculator \n\n--------------------------\n";
    static readonly string exitMessage = "Goodbye!";
    static readonly string menuOptionMessage = "Select one of the following operations\n1.Add\n2.Subtract\n3.Multiply\n4.Divide";
    static readonly string nullMessage = "Input is required";
    static readonly string validInputMessage = "Invalid input - must be a valid integer";
    static readonly string validOptionMessage = "Please enter a valid menu option.\n";
    static readonly string confirmExitMessage = "Do you want to perform another calculation. Press No to exit program: ";
    public static void ShowWelcomeMessage()
    {
        Console.WriteLine(welcomeMessage);
    }

    public static void ShowExitMessage()
    {
        Console.WriteLine(exitMessage);
    }

    public static void ShowMenuOptionMessage()
    {
        Console.WriteLine(menuOptionMessage);
    }

    public static void ShowNullMessage()
    {
        Console.WriteLine(nullMessage);
    }

    public static void ShowValidOptionMessage()
    {
        Console.WriteLine(validOptionMessage);
    }

    public static void ShowValidInputMessage()
    {
        Console.WriteLine(validInputMessage);
    }

    public static void ShowConfirmExitMessage()
    {
        Console.Write(confirmExitMessage);
    }

    public static void ShowCustomMessage(string message)
    {
        Console.WriteLine(message);
    }
}