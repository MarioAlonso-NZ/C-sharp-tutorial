/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: A simple console application to demonstrate object-oriented programming concepts.
 * Here I'm ignoring Encapsulation OOP pillar for simplicity. 
 */
var employee1 = new Employee()
{
    Name = "John Doe",
    Salary = 50000.00m
};
Employee employee2 = new() { Name = "Jane Smith", Salary = 60000.00m };
Employee employee3 = new Employee();

Console.WriteLine(employee1.GetInfo());
Console.WriteLine(employee2.GetInfo());
Console.WriteLine(employee3.GetInfo());

public class Employee { 
    public string Name { get; set; } // Add required or string? to avoid null warning
    public decimal Salary { get; set; }
    public string GetInfo() {
        return $"Name: {Name}, Salary: ${Salary}";
    }
};