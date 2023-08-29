using DeveloperTest.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DeveloperTest;

public class ToDoDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public ToDoDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = _configuration.GetConnectionString("connection")!;

        if (String.IsNullOrEmpty(connectionString))
        {
            throw new ConnectionIsNotConfigured();
        }


        optionsBuilder.UseSqlServer(connectionString)
            .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
    //entities

}