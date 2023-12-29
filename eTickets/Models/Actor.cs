using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
