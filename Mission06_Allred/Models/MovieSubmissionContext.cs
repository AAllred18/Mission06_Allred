using Microsoft.EntityFrameworkCore;

namespace Mission06_Allred.Models
{
    public class MovieSubmissionContext : DbContext //Liaison from the app to the database
    {
        public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base (options) //Constructor
        { 
        }

        //public DbSet<Movie> Movies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               
                new Category { CategoryID = 1, CategoryName="Miscellaneous"},
                new Category { CategoryID = 2, CategoryName = "Drama" },
                new Category { CategoryID = 3, CategoryName = "Television" },
                new Category { CategoryID = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 5, CategoryName = "Comedy" },
                new Category { CategoryID = 6, CategoryName = "Family" },
                new Category { CategoryID = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 8, CategoryName = "VHS" }


            );
        }

    }
}
