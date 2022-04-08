using System.ComponentModel.DataAnnotations;

namespace dab2_EfCore.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }

        //Foreign key - Location

        public string? Address { get; set; }
        public Location? Location { get; set; }
    }
}
