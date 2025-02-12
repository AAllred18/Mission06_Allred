using System.ComponentModel.DataAnnotations;

namespace Mission06_Allred.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set;} //Read only variable
        [Required]
        public string MovieCategory { get; set;}
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        [Range(1900, 2025)]
        public int MovieYear { get; set; }
        [Required]
        public string MovieDirector { get; set; }
        [Required]
        public string MovieRating { get; set; }
        public bool? MovieEdited { get; set; }
        public string? MovieLent { get; set; }
        public string? MovieNotes { get; set; }

    }
}
