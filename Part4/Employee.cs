using System;

namespace Part4
{
    public abstract class Employee: Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateHired { get; set; }

        protected Employee(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
        {
        }

        protected Employee(string name, string phoneNumber, string email, string department, double salary, DateTime dateHired) : base(name, phoneNumber, email)
        {
            Department = department;
            Salary = salary;
            DateHired = dateHired;
        }

        public abstract void CalculBonus();
        public abstract void CalculatedVacation();
    }
}