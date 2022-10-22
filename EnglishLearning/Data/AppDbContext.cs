using EnglishLearning.Models;
using Microsoft.EntityFrameworkCore;


namespace EnglishLearning.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<WordsPair> WordsPairs { get; set; }
    }
}
