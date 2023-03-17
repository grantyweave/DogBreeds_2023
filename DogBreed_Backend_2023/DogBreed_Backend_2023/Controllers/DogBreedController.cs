using Azure.Core;
using DogBreed_Backend_2023.DAL;
using DogBreed_Backend_2023.Models;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DogBreed_Backend_2023.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogBreedController : Controller
  {
    DogBreedRepository repo = new DogBreedRepository();

    [HttpGet("breed")]
    public List<DogBreed> GetAllBreeds()
    {
      string apiUri = $"https://dog-breeds2.p.rapidapi.com/dog_breeds";
      var apiTask = apiUri.WithHeaders(new
      {
        x_rapidapi_host = "dog-breeds2.p.rapidapi.com",
        x_rapidapi_key = "fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca"

      }).GetJsonAsync<List<DogBreed>>();
      apiTask.Wait();
      List<DogBreed> dogBreeds = apiTask.Result;
      return (dogBreeds);
    }

    [HttpGet("{id}")]
    public DogBreed GetById(int id)
    {
      return repo.FindById(id);
    }
  }
}
