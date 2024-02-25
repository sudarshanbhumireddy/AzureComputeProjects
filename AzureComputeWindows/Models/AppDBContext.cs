using Microsoft.EntityFrameworkCore;

namespace AzureComputeWindows.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> dbContext):base(dbContext)
        {
                
        }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed Courses Table
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseID = 1, CourseName = "IT",Rating=4.8 });
            modelBuilder.Entity<Course>().HasData(
               new Course { CourseID = 2, CourseName = "HR", Rating = 4.7 });
            modelBuilder.Entity<Course>().HasData(
               new Course { CourseID = 3, CourseName = "PayRoll", Rating = 4.6 });
            modelBuilder.Entity<Course>().HasData(
               new Course { CourseID = 4, CourseName = "Az204", Rating = 4.9 });
            modelBuilder.Entity<Course>().HasData(
               new Course { CourseID = 5, CourseName = "Az500", Rating = 4.8 });
        }
    }
}
