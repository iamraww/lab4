using System;

namespace Part4
{
    public class Staff: Employee
    {
        public string Title { get; set; }
        

        public Staff(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
        {
        }

        public Staff(string name, string phoneNumber, string email, string department, double salary, DateTime dateHired) : base(name, phoneNumber, email, department, salary, dateHired)
        {
        }

        public override void CalculBonus()
        {
            double bonus = 0.06 * Salary;
            Console.WriteLine($"Bonus: {bonus}");
        }

        public override void CalculatedVacation()
        {
            
        }
    }
}