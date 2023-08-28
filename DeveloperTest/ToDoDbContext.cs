using Microsoft.EntityFrameworkCore;

namespace DeveloperTest;

public class ToDoDbContext : DbContext
{
    //public DbSet<Student> Students { get; set; }
    //public DbSet<Course> Courses { get; set; }

    protected ToDoDbContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
    //entities

}