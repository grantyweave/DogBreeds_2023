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
        x_rapidapi_key = "e8eb4c4df6msh6a7d08468b4a2c5p1fae34jsn71c28a01494e"
      }).GetJsonAsync<List<DogBreed>>();
      // Sort the dog breeds alphabetically by name
      apiResult = apiResult.OrderBy(d => d.Breed).ToList();
      return apiResult;
    }

    [HttpGet("{breedName}")]
    public async Task<IActionResult> GetByBreedName(string breedName)
    {
      string apiUri = $"https://dog-breeds2.p.rapidapi.com/dog_breeds/breed/{breedName}";
      var apiResult = await apiUri.WithHeaders(new
      {
        x_rapidapi_host = "dog-breeds2.p.rapidapi.com",
        x_rapidapi_key = "fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca"

      }).GetJsonAsync<List<DogBreed>>();
      var firstDogBreed = apiResult.FirstOrDefault();
      if (firstDogBreed == null)
      {
        return NotFound("Breed not found.");
      };
      return Ok(apiResult.FirstOrDefault());
    }
  }
}
