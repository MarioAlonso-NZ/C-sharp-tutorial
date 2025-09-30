/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: Call the Employee class from the Company namespace and display employee information.
 * This demostrastes the use of namespaces to organize code.
 */
using Oriented_Object_Programming.Company;

Employee employee1 = new Employee()
{
    Id = -1,
    Name = "John Doe",
    Salary = 20000.00m
};
Employee employee2 = new Employee(209, "Jane Smith", 25000.00m);

Console.WriteLine(employee1.GetInfo());
Console.WriteLine(employee2.GetInfo());
