/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: Call the Employee class from the Company namespace and display employee information.\
 * This demonstrates the use of the abstract class Person, which is inherited by Employee, and in turn by Developer. 
 */
using Oriented_Object_Programming.Company;

Employee employee1 = new Employee(891, "Rubén", 18);
Developer developer1 = new Developer(271, "Mario", 21, new DateTime(2020, 1, 15));
// We're restricted to Person methods
Person p = new Developer(123, "Ana", 25, new DateTime(2021, 6, 1));
// Person p = new Person("Luis", 30); // This line would cause a compile-time error

Console.WriteLine(employee1.GetPersonalInfo());
Console.WriteLine(employee1.GetEmploymentStatus());
Console.WriteLine(developer1.GetPersonalInfo());
Console.WriteLine(developer1.GetEmploymentStatus());


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
