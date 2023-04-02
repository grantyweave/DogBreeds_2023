using DogBreed_Backend_2023.Models;
using Microsoft.EntityFrameworkCore;

namespace DogBreed_Backend_2023.DAL
{
  public class FavoriteRepository
  {
    public class FaveBreedsRepository
    {
      private BreedContext _dbContext = new BreedContext();
      private UserRepository userRepo = new UserRepository();
      private FaveBreedsRepository faveRepo = new FaveBreedsRepository();

      public void AddFavoriteBreed(string userLastName, FaveBreeds breedToAdd)
      {
        Users currentUser = _dbContext.Users.FirstOrDefault(x => x.LastName.ToLower() == userLastName.ToLower());

        if (currentUser != null)
        {
          currentUser.Favorites.Add(breedToAdd);
          _dbContext.SaveChanges();
        }
      }
      public List<FaveBreeds> GetAllUserFavoriteBreeds(string userLastName)
      {
        List<FaveBreeds> breedList = _dbContext.Users.FirstOrDefault(x => x.LastName == userLastName).Favorites.ToList();
        return breedList;

      }
      public void DeleteFavoriteBreed(string userLastName, int breedId)
      {
        Users currentUser = _dbContext.Users.FirstOrDefault(x => x.LastName.ToLower() == userLastName.ToLower());
        FaveBreeds breedToRemove = _dbContext.Favorites.FirstOrDefault(x => x.Id == breedId);
        if (currentUser != null)
        {
          currentUser.Favorites.Remove(breedToRemove);
        }

      }
    }
  }
}
