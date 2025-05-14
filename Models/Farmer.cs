using System.Collections.Generic;

namespace PROG_7311_POE_Part_2.Models
{
    public class Farmer
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // FK to ApplicationUser
        public string Name { get; set; }
        public string Region { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
