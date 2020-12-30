using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Иван", "Иванов")
            {
                Position = new Position(Position.director, 100000),
                Seniority = 3
            };
            employee.CalculateSalary();

            Console.WriteLine($"Имя: {employee.FirstName}, Фамилия: {employee.LastName}, Должность: {employee.Position.Name}, Оклад: {employee.Salary:0.00}, Налоговый сбор: {(employee.Salary * 0.18):0.00}");
        }
    }
}
