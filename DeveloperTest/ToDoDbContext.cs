using DeveloperTest.Exceptions;
using DeveloperTest.Exceptions.ExceptionMessages;
using DeveloperTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;

namespace DeveloperTest;

public class ToDoDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    

    public DbSet<Invoice> Groups { get; set; }

    public ToDoDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = _configuration.GetConnectionString("connection")!;

        if (String.IsNullOrEmpty(connectionString))
        {
            throw new ConnectionIsNotConfigured(Message.SQLIsNotConfigured);

        }


        optionsBuilder.UseSqlServer(connectionString)
            .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

}