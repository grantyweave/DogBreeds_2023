using DogBreed_Backend_2023.Models;
using Microsoft.EntityFrameworkCore;

namespace DogBreed_Backend_2023.DAL
{
  public class DogBreedRepository
  {
    private BreedContext _dbContext = new BreedContext();
    public List<DogBreed> GetAllBreeds()
    {
      return _dbContext.DogBreeds.ToList();
    }

    public DogBreed SearchByName(string breedName)
    {
      return _dbContext.DogBreeds.AsNoTracking().FirstOrDefault(x => x.breed == breedName);
    }

  }
}
