using DogBreed_Backend_2023.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;

namespace DogBreed_Backend_2023.DAL
{
  public class FavoriteRepository
  {
    private BreedContext _Db = new BreedContext();

    public FaveBreeds AddFavoriteBreed(FaveBreeds breedToAdd)
    {
      Users user = _Db.Users.FirstOrDefault(x => x.Id == breedToAdd.UserId);
      user.Favorites.Add(breedToAdd);
      _Db.SaveChanges();
      return breedToAdd;

    }
    public List<FaveBreeds> GetAllUserFavoriteBreeds(Users user)
    {
      List<FaveBreeds> breedList = user.Favorites.ToList();
      return breedList;

    }
    public void DeleteFavoriteBreed(FaveBreeds breedToDelete)
    {

      Users user = _Db.Users.FirstOrDefault(x => x.Id == breedToDelete.UserId);

      user.Favorites.Remove(breedToDelete);
      _Db.SaveChanges();

    }
  }
}
