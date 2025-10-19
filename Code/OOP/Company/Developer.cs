namespace Oriented_Object_Programming.Company
{
    public class Developer : Employee
    {
        public DateTime HireDate { get; set; }
        public Developer(int Id, string Name, int Age, DateTime HireDate, decimal Salary = 15000.00m) 
            : base(Id, Name, Age, Salary) 
        { 
            this.HireDate = HireDate;
        } // Call base class constructor
        public override string GetInfo(int number)
        {
            return base.GetInfo(number) + $", Hire Date: {HireDate.ToShortDateString()}";
        }
    }
}
