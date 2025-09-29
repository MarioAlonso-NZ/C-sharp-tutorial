/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: A simple console application to manage a list of devices with a limit.
 * NOTE: This code is part of a tutorial on structured programming, Module 1.
 *       The code demonstrates the use of functions, loops, conditionals, and arrays.
*/

using System.Text.RegularExpressions;

int limit = 5;
string[] devices = new string[limit];
int indexDevices = 0;
int userOption;

do
{
    userOption = GetUserOption();

    switch (userOption) { 
        case 1:
            AddDevice();
            break;
        case 2:
            ShowDevices();
            break;
        case 3:
            userOption = ExitVerification() == "y" ? 3 : 0;
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            Pause();
            break;
    }
}
while (userOption != 3);

void ShowMenu()
{
    Console.WriteLine("1. Add Device");
    Console.WriteLine("2. List Devices");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");
}

void Pause()
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

string ExitVerification()
{
    Console.WriteLine("You are about to exit. Are you sure? Yes (y) No (n)");
    string exitOption = Console.ReadLine().ToLower();
    while (exitOption != "n" && exitOption != "y")
    {
        Console.Clear();
        Console.WriteLine($"Your pressed ´{exitOption}´, which is not recognize. Try again Yes(y) No(n).");
        exitOption = Console.ReadLine().ToLower();
        userOption = exitOption == "y" ? 3 : 0;
        if (userOption == 3)
        {
            Console.Clear();
            ShowMenu();
        }
    }
    return exitOption;
}

int GetUserOption()
{
    Console.Clear();
    ShowMenu();
    string option = Console.ReadLine();
    Match match = Regex.Match(option, @"\d+");
    return match.Success ? int.Parse(match.Value) : -1;
}

void AddDevice()
{
    if (indexDevices < limit)
    {
        Console.Write("Enter device name: ");
        devices[indexDevices] = Console.ReadLine();
        indexDevices++;
    }
    else
    {
        Console.WriteLine("Device limit reached.");
        Pause();
    }
}

void ShowDevices() {
    Console.WriteLine("Registered Devices:");
    if(indexDevices == 0)
    {
        Console.WriteLine("No devices registered.");
        Pause();
        return;
    }
    for (int i = 0; i < indexDevices; i++)
    {
        Console.WriteLine($"{i + 1}. {devices[i]}");
    }
    Pause();
}