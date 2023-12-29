using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Models
{
    [PrimaryKey(nameof(MovieID), nameof(ActorID))]
    public class Actor_Movie
    {
        [Key, Column(Order = 0)]
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

        [Key, Column(Order = 1)]
        public int ActorID { get; set; }
    }
}
