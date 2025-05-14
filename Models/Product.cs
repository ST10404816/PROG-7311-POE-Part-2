using System;

namespace PROG_7311_POE_Part_2.Models
{
    public class Product
    {
        // Primary key for the Product table
        public int Id { get; set; }

        // The name of the product 
        public string Name { get; set; }

        // The category of the product 
        public string Category { get; set; }

        // The date the product was produced
        public DateTime ProductionDate { get; set; }

        // Foreign key 
        public int FarmerId { get; set; }

        // Navigation property representing the associated Farmer entity
        public Farmer Farmer { get; set; }
    }
}
