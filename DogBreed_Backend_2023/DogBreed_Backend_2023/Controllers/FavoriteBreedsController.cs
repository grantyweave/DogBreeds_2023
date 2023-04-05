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
    DogBreedRepository repo = new DogBreedRepository();
  }
}

[HttpPost("add")]
public User AddFavoriteBreed(int userId, string password, int breedId)
{
  User newFavoriteBreed = new User
  {
    UserId = userId,
    Password = password,
    BreedId = breedId
  };
  return repo.AddFavoriteBreed(newFavoriteBreed);
}


[HttpGet()]
public List<DogBreed> GetAll(int userId)
{
  return repo.GetAllUserFavoriteBreeds(userId);
}

[HttpDelete()]
public IActionResult DeleteFavoriteBreed(int userId, int breedId)
{
  try
  {
    repo.DeleteFavoriteBreed(userId, breedId);
    return Ok();
  }
  catch (Exception ex)
  {
    return NotFound();
  }
}
  }
}
