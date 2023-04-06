using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DogBreed_Backend_2023.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.AspNetCore.Components.Routing;

namespace DogBreed_Backend_2023.DAL
{
  public class UserContext : DbContext
  {
    // Two constructors, first one is empty
    public UserContext()
    {

    }

    // Second one injects the context options
    public UserContext(DbContextOptions options) : base(options)
    {

    }

    // Create the table based off the model
    public DbSet<User> Users { get; set; }


    private static IConfigurationRoot _configuration;

    // Set the configuration to use the JSON file for the connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        _configuration = builder.Build();
        string cnstr = _configuration.GetConnectionString("UserDb");
        optionsBuilder.UseSqlServer(cnstr);
      }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      var converter = new ValueConverter<int[], string>(
                v => string.Join(";", v),
                v => v.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(val => int.Parse(val)).ToArray());
      modelBuilder.Entity<User>().Property(x => x.FavoriteBreeds).HasConversion(converter);
    }
  }
}
