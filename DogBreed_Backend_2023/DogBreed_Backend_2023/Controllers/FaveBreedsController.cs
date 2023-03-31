using DogBreed_Backend_2023.DAL;
using DogBreed_Backend_2023.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DogBreed_Backend_2023.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FavoriteBreedsController : ControllerBase
  {
    private FaveBreedsRepository breedRepo = new FaveBreedsRepository();
    private UsersRepository userRepo = new UsersRepository();

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




//    [HttpPost("add")]
//    public User AddFavoriteBreed(int userId, string password, int breedId)
//    {
//      User newFavoriteBreed = new User
//      {
//        UserId = userId,
//        Password = password,
//        BreedId = breedId
//      };
//      return repo.AddFavoriteBreed(newFavoriteBreed);
//    }


//    [HttpGet()]
//    public List<DogBreed> GetAll(int userId)
//    {
//      return repo.GetAllUserFavoriteBreeds(userId);
//    }

//    [HttpDelete()]
//    public IActionResult DeleteFavoriteBreed(int userId, int breedId)
//    {
//      try
//      {
//        repo.DeleteFavoriteBreed(userId, breedId);
//        return Ok();
//      }
//      catch (Exception ex)
//      {
//        return NotFound();
//      }
//    }
