namespace dab2_EfCore.Models
{
    public class Chairman
    {
        public int Member_id { get; set; } //Primary key
        public string Name { get; set; }
        public int Cpr_number { get; set; }
        public string Address { get; set; }
        public int Cvr_number { get; set; } //Foreign key
    }
}
