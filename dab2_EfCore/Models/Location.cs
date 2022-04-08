using System.ComponentModel.DataAnnotations;

namespace dab2_EfCore.Models
{
    public class Location
    {
        //Many to one relationship with Municipality.cs

        [Key]
        public string? Address { get; set; }    //Primary key
        public int Bathroom { get; set; }
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }
        public int AccessKey { get; set; }

        //Foreign key - Municipality:
        public int Zipcode { get; set; }
        public Municipality? Municipality { get; set; }
    }
}
