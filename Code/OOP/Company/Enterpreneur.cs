namespace Oriented_Object_Programming.Company
{
    public class Enterpreneur : Person
    {
        private const string EmploymentStatus = "Self-Employed";
        public decimal NetWorth { get; set; }

        // Parameterized constructor
        public Enterpreneur(string Name, int Age, decimal NetWorth) :
            base(Name, Age)
        {
            this.NetWorth = NetWorth;
        }
        // Implementation of abstract method from Person class
        public override string GetEmploymentStatus()
        {
            return EmploymentStatus; // "Self-Employed";
        }
    }
}
