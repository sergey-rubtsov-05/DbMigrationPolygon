using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DbMigrationConsoleApp.Models;

namespace DbMigrationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory();
            using (var connection = connectionFactory.Create())
            {
                var persons = connection.Query<Person>("SELECT * FROM Persons");
                foreach (var person in persons)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
