namespace Oriented_Object_Programming.Company
{
    public abstract class Person
    {

        private string Name { get; set; }
        private int Age { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string GetPersonalInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
        // Abstract method to be implemented by derived classes
        public abstract string GetEmploymentStatus();
    }
}
