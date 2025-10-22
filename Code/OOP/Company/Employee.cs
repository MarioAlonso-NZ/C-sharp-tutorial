/*
 * Author: Mario N.Zavala
 * Date: September 2025
 * Description: Creation of an Employee class within the Company namespace.
 * This to demonstrate the use of namespaces to organize code.
 */
namespace Oriented_Object_Programming.Company
{
    public class Employee : Person, IHealthInsurance
    {
        private const string EmploymentStatus = "Employed";
        private int _id; // Private field
        public static int EmployeeCount = 0; // Static field to track number of employees

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
        public decimal Salary { get; set; }

        // Parameterized constructor with default value for Salary
        public Employee(int Id, string Name, int Age, decimal Salary = 15000.00m) :
            base(Name, Age)
        {
            this.Id = Id; // Using the property to leverage validation
            this.Salary = Salary;
            EmployeeCount++; // Increment employee count
        }
        // Overloaded method with a prefix parameter
        public string GetInfo(string prefix)
        {
            return $"{prefix} - Id: {Id}, Salary: ${Salary}";
        }
        public virtual string GetInfo(int number)
        {
            return $"Id: {Id}, Empolyee number: {number}, Salary: ${Salary}";
        }
        // Implementation of abstract method from Person class
        public override string GetEmploymentStatus()
        {
            return EmploymentStatus; // "Employed";
        }

        // Implementation of IHealthInsurance interface
        public string GetHealthInsurancePlan()
        {
            return "Standard Health Insurance Plan";
        }
    }
}
