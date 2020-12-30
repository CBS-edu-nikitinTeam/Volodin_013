using System;

namespace BonusExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new User("Иванов", "Иван", "I.IVANOV", 40).GetUserDetails());
        }
    }
}
