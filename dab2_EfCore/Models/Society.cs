using System.ComponentModel.DataAnnotations;

namespace dab2_EfCore.Models
{
    public class Society
    {
        [Key]
        public int Cvr_number {get;set;} //Primary key
        public int Zip_code { get; set; }

        public string Activity { get; set; }

        public Chairman Chairman { get; set; }
        public List<Member> Members { get; set; }
    }
}
