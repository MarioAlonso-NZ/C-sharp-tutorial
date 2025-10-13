/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: A simple console application to demonstrate Properties as wrappers of fields.
 * NOTE: I am already implementing Encapsulation using Fields -usually as private.
 */
Employee employee1 = new Employee()
{
    Id = -1,
    Name = "John Doe",
    Salary = 20000.00m
};
Employee employee2 = new Employee(209, "Jane Smith", 25000.00m);

Console.WriteLine(employee1.GetInfo());
Console.WriteLine(employee2.GetInfo());

public class Employee { 
    private int _id; // Private field
    public int Id { 
        get { return _id; } 
        set {
            if (value < 0)
            {
                Console.WriteLine("Invalid Id. Setting to default value 123.");
                value = 123;
            }
            _id = value; // value is a keyword representing the value being assigned 
        } 
    } // Public property
    public string Name { get; set; } // Add required or string? to avoid null warning
    public decimal Salary { get; set; }
    public Employee() {
        Id = 123; // Using the property to leverage validation
        Name = "Default Name";
        Salary = 15000.00m;
    }
    // Parameterized constructor with default value for Salary
    public Employee(int Id, string Name, decimal Salary = 15000.00m)
    {
        this.Id = Id; // Using the property to leverage validation
        this.Name = Name;
        this.Salary = Salary;
    }
    public string GetInfo() {
        return $"Id: {Id}, Name: {Name}, Salary: ${Salary}";
    }
};