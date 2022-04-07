using System.ComponentModel.DataAnnotations;

namespace dab2_EfCore.Models
{
    public class Member
    {
        [Key]
        public int Member_id { get; set; } //Primary key
        public string? Name { get; set; }

        public int Cvr_number { get; set; } //Foreign key
        public Society? Society { get; set; }
    }
}
