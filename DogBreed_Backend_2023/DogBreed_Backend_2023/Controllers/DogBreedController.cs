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
    public async Task<IActionResult> GetAllBreeds()
    {
      List<DogBreed> apiResult = await GetAllDogBreeds();
      List<DogBreed> dogBreeds = apiResult;
      return Ok(dogBreeds);
    }

    private static async Task<List<DogBreed>> GetAllDogBreeds()
    {
      string apiUri = $"https://dog-breeds2.p.rapidapi.com/dog_breeds";
      var apiResult = await apiUri.WithHeaders(new
      {
        x_rapidapi_host = "dog-breeds2.p.rapidapi.com",
        x_rapidapi_key = "fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca"

      }).GetJsonAsync<List<DogBreed>>();
      return apiResult;
    }


    //[HttpGet("{breed}")]
    //public DogBreed SearchByBreed(string breed)
    //{

    //  string apiUri = $"https://dog-breeds2.p.rapidapi.com/dog_breeds/breed/";
    //  var apiTask = apiUri.WithHeaders(new
    //  {
    //    x_rapidapi_host = "dog-breeds2.p.rapidapi.com",
    //    x_rapidapi_key = "f948690f68msh90c55661bcb1797p134afajsn9abb30e25b4a"

    //  }).GetJsonAsync<DogBreed>();
    //  apiTask.Wait();
    //  DogBreed dogBreed = apiTask.Result;
    //  return dogBreed;
    //}


  }
}
