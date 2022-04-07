namespace dab2_EfCore.Models
{
    public class Municipality
    {
        //One to many relationship with Society.cs and Location.cs

        public int Zipcode { get; set; }
        public string? Name { get; set; }
        public int AccessKey { get; set; }

        //Foreign key - Society:
        public List<Society>? ListOfSocieties { get; set; }

        //Foreign key - Location:
        public List<Location>? Locations { get; set; }

    }
}
