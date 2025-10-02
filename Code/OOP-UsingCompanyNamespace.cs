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

Developer developer1 = new Developer(271, "Mario", new DateTime(2025, 10, 1));

Console.WriteLine(employee1.GetInfo());
Console.WriteLine(developer1.GetInfo());
