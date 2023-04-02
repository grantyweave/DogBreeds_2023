using DogBreed_Backend_2023.DAL;
using DogBreed_Backend_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.EntityFrameworkCore;
using static DogBreed_Backend_2023.DAL.FavoriteRepository;

namespace DogBreed_Backend_2023.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FavoriteController : Controller
  {
    private FaveBreedsRepository breedRepo = new FaveBreedsRepository();
    private UserRepository userRepo = new UserRepository();

    [HttpPost("add")]
    public void AddFaveBreedToUser(string userLastName, FaveBreeds breedToAdd)
    {
      breedRepo.AddFavoriteBreed(userLastName, breedToAdd);
    }
    [HttpGet("userLastName")]
    public List<FaveBreeds> GetUsersFaveBreeds(string userLastName)
    {
      List<FaveBreeds> breedList = breedRepo.GetAllUserFavoriteBreeds(userLastName);
      return breedList;
    }
    [HttpDelete("delete")]
    public void DeleteUserFave(string userLastName, int breedId)
    {
      breedRepo.DeleteFavoriteBreed(userLastName, breedId);
    }


  }
}
