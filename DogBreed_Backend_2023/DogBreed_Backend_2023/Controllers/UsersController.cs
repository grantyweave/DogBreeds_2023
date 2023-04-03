using Microsoft.AspNetCore.Mvc;
using DogBreed_Backend_2023.Models;
using DogBreed_Backend_2023.DAL;
using System.Net;

namespace DogBreed_Backend_2023.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : Controller
  {
    // user api endpoints
    UsersRepository userRepo = new UsersRepository();


    [HttpPost("login")]
    public Users LoginUser(Users newUser)
    {
      return userRepo.LoginUser(newUser);
    }

    [HttpGet()]
    public List<Users> GetAll()
    {
      return userRepo.GetAllUsers();
    }

    [HttpGet("{id}")]
    public Users getUserById(int userId)
    {
      Users user = userRepo.getUserById(userId);
      return user;

    }

    [HttpDelete("delete")]
    public void DeleteUser(Users userToDelete)
    {
      userRepo.DeleteUser(userToDelete);
    }

    [HttpPost("update")]
    public void UpdateUser(string firstName, string lastName, string email, string password, bool isAdmin, Users userToUpdate)
    {
      userRepo.UpdateUser(firstName, lastName, email, password, isAdmin, userToUpdate);
    }

    // favorites api endpoints
    FaveBreedsRepository faveRepo = new FaveBreedsRepository();

    [HttpPost("/favorites/add")]
    public FaveBreeds AddFavoriteBreed(FaveBreeds breedToAdd)
    {

      faveRepo.AddFavoriteBreed(breedToAdd);
      return breedToAdd;
    }
    [HttpGet("/favorites")]
    public List<FaveBreeds> GetFaveBreeds(Users user)
    {
      return faveRepo.GetAllUserFavoriteBreeds(user);
    }
    [HttpDelete("/favorites/delete")]
    public void DeleteFaveBreedFromUser(FaveBreeds breedToDelete)
    {

    }
  }
}

