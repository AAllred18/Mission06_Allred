using Microsoft.EntityFrameworkCore;

namespace Mission06_Allred.Models
{
    public class MovieSubmissionContext : DbContext 
    {
        public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base (options) //Constructor
        { 
        }

        public DbSet<Movie> Movies { get; set; }

    }
}
