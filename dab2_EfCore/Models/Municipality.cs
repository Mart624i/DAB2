namespace dab2_EfCore.Models
{
    public class Municipality
    {
        public int zipcode { get; set; }
        public string? name { get; set; }
        public int AccessKey { get; set; }

        //Foreign key til cvr number her
        public List<Society>? ListOfSocieties { get; set; }

    }
}
