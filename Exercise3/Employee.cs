using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Salary { get; private set; }
        public Position Position { get; set; }
        public int Seniority { get; set; }

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public bool CalculateSalary()
        {
  
            if (!(this.Position.Name switch {
                Exercise3.Position.director => true,
                Exercise3.Position.manager => true,
                Exercise3.Position.specialist => true,
                _ => false,
            }))
            {
                return false;
            }

            this.Salary = this.Position.Salary * new Bonus().GetBonusRateBySeniority(this.Seniority);

            return true;
        }
    }
}
