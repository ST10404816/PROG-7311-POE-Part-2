namespace PROG_7311_POE_Part_2.Models
{
    public class Employee
    {
        // Primary key for the Employee table
        public int Id { get; set; }

        // Foreign key 
        public string UserId { get; set; }

        // The name of the employee
        public string Name { get; set; }

        // The department to which the employee belongs
        public string Department { get; set; }
    }
}
