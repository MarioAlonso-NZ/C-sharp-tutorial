/*
 * Author: Mario N.Zavala
 * Date: October 2025
 * Description: Call the Employee class from the Company namespace and display employee information.
 * This demonstrates the use of IHealthInsurence inteface. 
 */
using Oriented_Object_Programming.Company;

Person p1 = new Employee(891, "Rubén", 18);
Person p2 = new Employee(891, "Lovelace", 18);
Person p3 = new Employee(891, "Babbage", 18);
Person p4 = new Employee(891, "Newman", 18);
Person p5 = new Developer(271, "Mario", 21, new DateTime(2020, 1, 15));
Person p6 = new Enterpreneur("Laura", 35, 1000000.00m);

// Display employment count using static member
Console.WriteLine(Employee.EmployeeCount);

// Display employment status using polymorphism
ShowHelathInsurancePlan(p1); // Employee 
ShowHelathInsurancePlan(p2); // Developer
ShowHelathInsurancePlan(p5); // Enterpreneur

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
