namespace DbMigrationConsoleApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public override string ToString()
        {
            return $"{Id} - {FirstName}";
        }
    }
}