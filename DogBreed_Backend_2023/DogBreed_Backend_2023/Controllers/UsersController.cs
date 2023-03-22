using DogBreed_Backend_2023.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DogBreed_Backend_2023.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : Controller
  {
    UserRepository repo = new UserRepository();

    [HttpPost("add")]


  }
}
