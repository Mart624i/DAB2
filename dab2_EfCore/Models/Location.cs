namespace dab2_EfCore.Models
{
    public class Location
    {
        public string? Address { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public int Bathroom { get; set; }

        //Foreign key:
        public List<Municipality>? ListOfMunicipalities { get; set; }
    }
}
