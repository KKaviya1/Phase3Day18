
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesAPI.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]

        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}