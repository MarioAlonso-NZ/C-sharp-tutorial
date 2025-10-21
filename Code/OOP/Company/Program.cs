/*
 * Author: Mario N.Zavala
 * Date: October 2025
 * Description: Call the Employee class from the Company namespace and display employee information.
 * This demonstrates the use of IHealthInsurence inteface. 
 */
using Oriented_Object_Programming.Company;

Person p1 = new Employee(891, "Rubén", 18);
Person p2 = new Developer(271, "Mario", 21, new DateTime(2020, 1, 15));
Person p3 = new Enterpreneur("Laura", 35, 1000000.00m);

// Display employment status using polymorphism
ShowHelathInsurancePlan(p1); // Employee 
ShowHelathInsurancePlan(p2); // Developer
ShowHelathInsurancePlan(p3); // Enterpreneur

void ShowHelathInsurancePlan(Person p)
{
    if (p is IHealthInsurance emp)
    {
        Console.WriteLine(emp.GetHealthInsurancePlan());
    }
}

// Syntantic sugar for creating an object
void Show(Person p) =>
    Console.WriteLine(p.GetEmploymentStatus());


while (false)
{
    Console.Clear();
    Console.WriteLine("Enter your choice:");
    string input = Console.ReadLine();

    try
    {
        // Try to convert the user's input directly into an integer.
        int number = int.Parse(input);

        // This line only runs if the conversion above was successful.
        Console.WriteLine($"You selected option {number}");
        Pause();
    }
    catch (FormatException)
    {
        // This 'catch' block runs only if int.Parse fails
        // because the input wasn't a valid number (e.g., "hello" or "1.5").
        Console.WriteLine("Error: Please enter a valid whole number.");
        Pause();
    }
}

// Assuming you have a Pause() method like this somewhere in your code:
void Pause()
{
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}
