using Microsoft.AspNetCore.Mvc;
using DogBreed_Backend_2023.Models;
using DogBreed_Backend_2023.DAL;

namespace DogBreed_Backend_2023.Controllers
{
  public class UserController : Controller
  {
    UserRepository repo=new UserRepository();

    [HttpPost("add")]
    public User AddNewUser(string firstName, string lastName, string email, string password)
    {
      User newUser = new User
      {
        FirstName= firstName,
        LastName= lastName,
        Email= email,
        Password = password,

      };
      return repo.AddNewUser(newUser);
    }
  }
}

