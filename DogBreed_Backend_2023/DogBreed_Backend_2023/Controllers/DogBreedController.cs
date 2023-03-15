using Azure.Core;
using DogBreed_Backend_2023.DAL;
using DogBreed_Backend_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DogBreed_Backend_2023.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogBreedController : Controller
  {
    DogBreedRepository repo = new DogBreedRepository();

    /*var client = new HttpClient();
    var request = new HttpRequestMessage(HttpMethod.Get, "https://dog-breeds2.p.rapidapi.com/dog_breeds");
    Request.Headers.Add("X-RapidAPI-Key", "fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca");
request.Headers.Add("X-RapidAPI-Host", "dog-breeds2.p.rapidapi.com");
var response = await client.SendAsync(request);
    response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());*/


    /*public IActionResult Index()
    {
      string apiUri = "https://dog-breeds2.p.rapidapi.com/dog_breeds";
      var apiTask = apiUri.WithHeaders(new
      {
        x_rapidapi_host = "dog-breeds2.p.rapidapi.com",
        x_rapidapi_key = "fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca"

      }).GetJsonAsync<List<DogBreedApi>>();
      apiTask.Wait();
      List<DogBreedApi> breeds = apiTask.Result;
      return View(breeds);
    }*/


    [HttpGet()]
    public List<DogBreedApi> GetAll()
    {
      return repo.GetAllBreeds();
    }

    [HttpGet("{id}")]
    public DogBreedApi GetById(int id)
    {
      return repo.FindById(id);
    }
    }
  }
