using FluentMigrator;

namespace BusinessConsoleApp.Migrations.Migrations
{
    [Migration(201706171310)]
    public class AddColumnLastNameToPersons : Migration
    {
        public override void Up()
        {
            Alter.Table("Persons").AddColumn("LastName").AsAnsiString(70).Nullable();
        }

        public override void Down()
        {
            Delete.Column("LastName").FromTable("Persons");
        }
    }
}