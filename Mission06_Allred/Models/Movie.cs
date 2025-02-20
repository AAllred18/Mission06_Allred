using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Forms;

namespace Mission06_Allred.Models
{
    public class Movie
    {

        //Title, Year, Edited, CopiedToPlex are required
        [Key]
        [Required]
        public int MovieID { get; set;} //Read only variable

        [ForeignKey("CategoryID")]
        public int? CategoryID { get; set;}
        public Category? Category { get; set;}

        [Required]
        public string MovieTitle { get; set; }

        [Required (ErrorMessage ="You must enter a year between 1888 and 2025")]
        [Range(1888, 2025)]
        public int MovieYear { get; set; }
       
        public string? MovieDirector { get; set; }
        
        public string? MovieRating { get; set; }

        [Required]
        public bool MovieEdited { get; set; }
        public string? MovieLent { get; set; }

        [Required]
        public bool MoviePlex { get; set; }
        public string? MovieNotes { get; set; }

    }
}
