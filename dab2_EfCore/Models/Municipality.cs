using System.ComponentModel.DataAnnotations;

namespace dab2_EfCore.Models
{
    public class Municipality
    {
        //One to many relationship with Society.cs and Location.cs

        [Key]
        public int? Zipcode { get; set; }    //Primary key
        public string? Name { get; set; }
        public int AccessKey { get; set; }

        //Foreign key - Society:
        public List<Society>? ListOfSocieties { get; set; }

        //Foreign key - Location:
        public List<Location>? Locations { get; set; }

    }
}
