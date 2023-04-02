using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DogBreed_Backend_2023.Models;

namespace DogBreed_Backend_2023.DAL
{
  public class BreedContext : DbContext
  {
    // Two constructors, first one is empty
    public BreedContext()
    {

    }

    // Second one injects the context options
    public BreedContext(DbContextOptions options) : base(options)
    {

    }

    // Create the table based off the model
    public DbSet<DogBreed> DogBreeds { get; set; }

    public DbSet<Users> Users { get; set; }
    public DbSet<FaveBreeds> Favorites { get; set; }



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
        string cnstr = _configuration.GetConnectionString("BreedDb");
        optionsBuilder.UseSqlServer(cnstr);
      }
    }
  }
}
