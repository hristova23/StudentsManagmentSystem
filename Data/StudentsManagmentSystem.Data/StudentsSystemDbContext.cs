namespace StudentsSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class StudentsSystemDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Server=DESKTOP-LTGBELC\\SQLEXPRESS;Database=StudentSystem;Integrated Security=True;"); 
            }
        }
        //Configures table relations (if such exist) :
        //protected override void OnModelCreating(ModelBuilder builder);
    }
}
