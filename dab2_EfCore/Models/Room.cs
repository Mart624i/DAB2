namespace dab2_EfCore.Models
{
    public class Room
    {
        public int? RoomNumber { get; set; }
        public int? Capacity { get; set; }

        //Foreign key:
        public List<Location>? ListOfLocations { get; set; }
    }
}
