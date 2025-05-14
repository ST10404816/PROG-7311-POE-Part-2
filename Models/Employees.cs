namespace PROG_7311_POE_Part_2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // FK to ApplicationUser
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
