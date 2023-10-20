public static class ApplicationMessage
{
    public static readonly string welcomeMessage = "--------------------------\n\n Welcome to Calculator \n\n--------------------------\n";
    public static readonly string exitMessage = "Goodbye!";
    public static readonly string menuOptionMessage = "Select one of the following operations\n1.Add\n2.Subtract\n3.Multiply\n4.Divide";
    public static readonly string nullMessage = "Input is required";
    public static readonly string validInputMessage = "Invalid input - must be a valid integer";
    public static readonly string validOptionMessage = "Please enter a valid menu option.\n";
    public static readonly string confirmExitMessage = "Do you want to perform another calculation. Press No to exit program: ";

    public static void ShowCustomMessage(string message)
    {
        Console.WriteLine(message);
    }
}