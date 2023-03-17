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

    public DogBreed FindById(int id)
    {
      // AsNoTracking will not lock the ID allowing updating it after finding it
      return _dbContext.DogBreeds.AsNoTracking().FirstOrDefault(x => x.Id == id);
    }

    public FavoriteBreed AddFavoriteBreed(FavoriteBreed newFavoriteBreed)
    {
      _dbContext.FavoriteBreeds.Add(newFavoriteBreed);
      _dbContext.SaveChanges();
      return newFavoriteBreed;
    }

    public List<DogBreed> GetAllUserFavoriteBreeds(int userId)
    {
      var usersBreeds= _dbContext.FavoriteBreeds.Where(x => x.UserId == userId).Select(x => x.BreedId).ToList();
      return _dbContext.DogBreeds.Where(x => usersBreeds.Contains(x.Id)).ToList();

    }

    public void DeleteFavoriteBreed(int userId, int breedId)
    {
      var favorite = _dbContext.FavoriteBreeds.FirstOrDefault(x => x.UserId == userId && x.BreedId == breedId);
      if (favorite != null)
      {
        _dbContext.FavoriteBreeds.Remove(favorite);
        _dbContext.SaveChanges();
      }
    }

  }
}
