using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Position
    {
        public const string director = "директор";
        public const string manager = "менеджер";
        public const string specialist = "специалист";

        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Position(string name, double salary)
        {
            if (IsPositionNameCorrect(name)) {
                this.Name = name.ToLower();
            }
            this.Salary = salary;
        }

        private bool IsPositionNameCorrect(string name)
        {
            return name switch
            {
                Position.director => true,
                Position.manager => true,
                Position.specialist => true,
                _ => false,
            };
        }
    }
}
