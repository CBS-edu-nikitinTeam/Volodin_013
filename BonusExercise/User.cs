using System;
using System.Collections.Generic;
using System.Text;

namespace BonusExercise
{
    class User
    {
        public string LastName { get; private set; }
        public string Login { get; private set; }
        public string FirstName { get; private set; }
        public int Age { get; private set; }

        readonly DateTime createdAt;

        public User(string lastName, string firstName, string login, int age)
        {
            LastName = lastName;
            Login = login;
            FirstName = firstName;
            Age = age;
            createdAt = DateTime.Now;
        }

        public string GetUserDetails()
        {
            return new StringBuilder().Append($"Фамилия: {this.LastName}").Append(Environment.NewLine)
                .Append($"Имя: {this.FirstName}").Append(Environment.NewLine)
                .Append($"Логин: {this.Login}").Append(Environment.NewLine)
                .Append($"Возраст: {this.Age}").Append(Environment.NewLine)
                .Append($"Дата создания: {this.createdAt}").ToString();
        }
    }
}
