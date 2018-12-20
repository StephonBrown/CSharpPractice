using System;

namespace PracticeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = Console.ReadLine();
            p.LastName = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int num);
            p.Age = num;

            Console.WriteLine($"{p.FirstName} {p.LastName} is {p.Age.ToString()} years old");
            Console.WriteLine("Press any key");
            Console.ReadLine();
           
        }
    }
}
