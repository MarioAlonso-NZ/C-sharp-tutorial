namespace Oriented_Object_Programming.Company
{
    public class Developer : Employee
    {
        public DateTime HireDate { get; set; }
        public Developer(int Id, string Name, DateTime HireDate, decimal Salary = 15000.00m) 
            : base(Id, Name, Salary) 
        { 
            this.HireDate = HireDate;
        } // Call base class constructor
        public override string GetInfo()
        {
            return base.GetInfo("Developer") + $", Hire Date: {HireDate.ToShortDateString()}";
        }
    }
}
