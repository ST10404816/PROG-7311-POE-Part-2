using System.Collections.Generic;

namespace PROG_7311_POE_Part_2.Models
{
    public class Farmer
    {
        // Primary key for the Farmer table
        public int Id { get; set; }

        // Foreign key 
        public string UserId { get; set; }  // FK to ApplicationUser

        // The name of the farmer
        public string Name { get; set; }

        // The geographic region the farmer is associated with
        public string Region { get; set; }

        // Navigation property representing the products associated with this farmer
        public ICollection<Product> Products { get; set; }
    }
}
