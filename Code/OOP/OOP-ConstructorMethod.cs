/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: A simple console application to demonstrate Constructor Method and variants.
 * NOTE: I am still ingoring the Encasulation principle for simplicity's sake.
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
    // Default constructor
    public Employee() {
        Name = "No Name";
        Salary = 0.0m;
    }
    // Parameterized constructor with default value for Salary
    public Employee(string Name, decimal Salary = 15000.00m)
    {
        this.Name = Name;
        this.Salary = Salary;
    }
    public string GetInfo() {
        return $"Name: {Name}, Salary: ${Salary}";
    }
};