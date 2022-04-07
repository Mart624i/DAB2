namespace dab2_EfCore.Models
{
    public class Location
    {
        //Many to one relationship with Municipality.cs
        //One to many relationship with Room.cs

        public string? Address { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public int Bathroom { get; set; }

        //Foreign key - Municipality:
        public int Zipcode { get; set; }
        public Municipality? Municipality { get; set; }

        //Foreign key - Room:
        public List<Room>? Rooms { get; set; }

        //Old:
        //public List<Municipality>? ListOfMunicipalities { get; set; }
    }
}
