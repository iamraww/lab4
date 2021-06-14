using System;

namespace Part4
{
    public class Faculty: Employee
    {
        public Faculty(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
        {
        }

        public Faculty(string name, string phoneNumber, string email, string department, double salary, DateTime dateHired) : base(name, phoneNumber, email, department, salary, dateHired)
        {
        }

        public override void CalculBonus()
        {
            double bonus = 1000 + 0.06 * Salary;
            Console.WriteLine($"Bonus: {bonus}");
        }

        public override void CalculatedVacation()
        {
            throw new NotImplementedException();
        }
    }
}