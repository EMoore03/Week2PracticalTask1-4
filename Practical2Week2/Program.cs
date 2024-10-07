/*
 * Practical 2
 * Information: Methods demo
 * Version 1
 * Author Dr James Connolly
 * Date: September
 */

Main();
static void Main()
{
    string message = "";
    do
    {
        PrintMenu();
        int option = InputOption();
        message = GetMessage(option);
        Console.WriteLine(message);
    } while (message != "Goodbye");
}
static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below: ");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit application");
}
static int InputOption()
{
    // Define local variable
    int option;
    try
    {
        option = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        option = 0;
    }
    return option;
}
static string GetMessage(int language)
{
    // This is a local variable and is only used
    // within this method.
    string msg = "";
    switch (language)
    {
        case 0:
            msg = "Goodbye";
            break;
        case 1:
            msg = "Bonjour";
            break;
        case 2:
            msg = "Ola";
            break;
        case 3:
            msg = "Hallo";
            break;
        case 4:
            msg = "Ciao";
            break;
        default:
            msg = "Please enter a valid option";
            break;
    }
    return msg;
}
