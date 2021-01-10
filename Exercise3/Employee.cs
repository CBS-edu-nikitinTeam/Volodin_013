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

        public double Bonus
        {
            get
            {
                if (Seniority < 1)
                {
                    return Seniority;
                }
                else if (Seniority < 3)
                {
                    return 1.1 * Seniority;
                }
                else if (Seniority < 5)
                {
                    return 1.2 * Seniority;
                }
                else
                {
                    return 1.3 * Seniority;
                }
            }
        }

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public bool CalculateSalary()
        {
  
            if (!(this.Position.Name switch {
                Position.director => true,
                Position.manager => true,
                Position.specialist => true,
                _ => false,
            }))
            {
                return false;
            }

            this.Salary = this.Position.Salary * Bonus; //new Bonus().GetBonusRateBySeniority(this.Seniority);

            return true;
        }
    }
}
