/******************************************************************************
* This is the corrected and functional version of the code.
*******************************************************************************/
using System;
using System.Text.RegularExpressions; // Required for using Regex

class HelloWorld
{
    // --- Class-Level (Static) Variables ---
    // Moved here so all static methods can access them.
    static int limit = 5;
    static string[] devices = new string[limit];
    static int indexDevices = 0;

    // --- Main Program Entry Point ---
    static void Main()
    {
        int userOption;

        do
        {
            userOption = GetUserOption();

            switch (userOption)
            {
                case 1:
                    AddDevice();
                    break;
                case 2:
                    ShowDevices();
                    break;
                case 3:
                    // The loop will exit if the user confirms with 'y'.
                    // If they enter 'n', we change the option to continue the loop.
                    if (ExitVerification() == "n")
                    {
                        userOption = 0; // A non-exit value to keep the loop going
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Pause();
                    break;
            }
        }
        while (userOption != 3);

        Console.WriteLine("Exiting program...");
    }

    // --- Helper Methods ---
    // All methods are now static members of the HelloWorld class.

    static void ShowMenu()
    {
        Console.WriteLine("1. Add Device");
        Console.WriteLine("2. List Devices");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static string ExitVerification()
    {
        Console.WriteLine("You are about to exit. Are you sure? Yes (y) / No (n)");
        string exitOption;

        // Loop until the user provides a valid input ('y' or 'n')
        do
        {
            exitOption = Console.ReadLine().ToLower();
            if (exitOption != "y" && exitOption != "n")
            {
                Console.WriteLine($"You pressed '{exitOption}', which is not recognized. Try again: Yes (y) or No (n).");
            }
        } while (exitOption != "y" && exitOption != "n");

        return exitOption;
    }

    static int GetUserOption()
    {
        Console.Clear();
            Console.Write("Enter device name: ");
            Console.WriteLine($"Device '{deviceName}' added successfully.");
        }
        else
        {
            Console.WriteLine("Device limit reached. Cannot add more devices.");
        }
        Pause();
    }

    static void ShowDevices()
    {
        Console.Clear();
        Console.WriteLine("--- Registered Devices ---");
        if (indexDevices == 0)
        {
            Console.WriteLine("No devices registered yet.");
        }
        else
        {
            for (int i = 0; i < indexDevices; i++)
            {
                Console.WriteLine($"{i + 1}. {devices[i]}");
            }
        }
        Pause();
    }
}            string deviceName = Console.ReadLine();
            devices[indexDevices] = deviceName;
            indexDevices++;
        ShowMenu();
        if (indexDevices < limit)
        {
    static void AddDevice()
    {
        Console.Clear();
        string option = Console.ReadLine();
        // Use Regex to safely find a number in the input
        Match match = Regex.Match(option, @"\d+");
