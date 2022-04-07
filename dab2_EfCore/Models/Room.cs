namespace dab2_EfCore.Models
{
    public class Room
    {
        //Many to one relationship with Location.cs

        public int? RoomNumber { get; set; }
        public int? Capacity { get; set; }

        //Foreign key - Location:
        public string? Address { get; set; }
        public Location? Location { get; set; }

        //Old:
        //public List<Location>? ListOfLocations { get; set; }
    }
}
