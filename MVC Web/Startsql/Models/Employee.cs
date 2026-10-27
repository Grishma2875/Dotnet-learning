namespace Startsql.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
        public string Gender { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
