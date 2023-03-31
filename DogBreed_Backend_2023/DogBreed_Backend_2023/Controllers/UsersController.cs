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
    UsersRepository repo=new UsersRepository();

    [HttpPost("add")]
    public Users AddNewUser(string firstName, string lastName, string email, string password)
    {
      Users newUser = new Users
      {
        FirstName = firstName,
        LastName = lastName,
        Email = email,
        Password = password,

      };
      return repo.AddNewUser(newUser);
    }


    [HttpGet()]
    public List<Users> GetAll()
    {
      return repo.GetAllUsers();
    }

    [HttpGet("{id}")]
    public Users GetUserById(int id)
    {
      return repo.FindByUserId(id);
    }

    [HttpPost("delete/{id}")]
    public HttpResponseMessage DeleteUserById(int id)
    {
      try
      {
        if (repo.DeleteUserById(id) == true)
        {
          return new HttpResponseMessage(System.Net.HttpStatusCode.NoContent);
        }
        else
        {
          return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
      }
      catch (Exception ex)
      {
        return new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
      }
    }

    [HttpPost("update")]
    public HttpResponseMessage UpdateUser(string userFirstName,string userLastName, string password)
    {
      Users userToUpdate = new Users
      {
        FirstName = userFirstName,
        LastName = userLastName,
        Password = password
      };
      try
      {
        if (repo.UpdateUser(userToUpdate) == true)
        {
          return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
        else
        {
          return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
      }
      catch (Exception ex)
      {
        return new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
      }
    }
  }
}

