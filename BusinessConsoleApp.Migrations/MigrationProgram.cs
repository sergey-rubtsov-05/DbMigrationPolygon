using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors;

namespace BusinessConsoleApp.Migrations
{
    class MigrationProgram
    {
        public static void Main()
        {
            var connectionString = new ConnectionFactory().ConnectionString;
            Console.WriteLine(connectionString);
            Migrate(connectionString);
            Console.WriteLine("DONE");
            Console.ReadKey();
        }

        private static void Migrate(string connectionString)
        {
            var announcer = new TextWriterAnnouncer(Console.Out);
            var migrationContext = new RunnerContext(announcer);
            var factory = new FluentMigrator.Runner.Processors.SqlServer.SqlServer2012ProcessorFactory();
            var assembly = typeof(MigrationProgram).Assembly;
            using (var processor = factory.Create(connectionString, announcer, new ProcessorOptions()))
            {
                var runner = new MigrationRunner(assembly, migrationContext, processor);
                runner.MigrateUp();
            }
        }
    }
}
