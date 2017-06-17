using System;
using BusinessConsoleApp.Models;
using Dapper;

namespace BusinessConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory();
            using (var connection = connectionFactory.Create())
            {
                var persons = connection.Query<Person>($"SELECT {nameof(Person.Id)}, {nameof(Person.FirstName)}, {nameof(Person.LastName)} FROM Persons");
                foreach (var person in persons)
                {
                    Console.WriteLine(person);
                }
            }
            Console.ReadKey();
        }
    }
}
