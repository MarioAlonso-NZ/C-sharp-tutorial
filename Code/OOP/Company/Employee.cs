/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: Creation of an Employee class within the Company namespace.
 * This to demonstrate the use of namespaces to organize code.
 */
namespace Oriented_Object_Programming.Company
{
    public class Employee
    {
        private int _id; // Private field
        public int Id
        {
            get { return _id; }
            set
            {
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
        public Employee()
        {
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
        public string GetInfo()
        {
            return $"Id: {Id}, Name: {Name}, Salary: ${Salary}";
        }
	// Overloaded method with a prefix parameter 
	public string GetInfo(string prefix) 
	{
	    return $"{prefix} - Id: {Id}, Name: {Name}, Salary: ${Salary}";
	}
    }
}
