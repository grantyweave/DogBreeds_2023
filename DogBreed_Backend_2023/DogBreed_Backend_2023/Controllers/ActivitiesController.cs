using DogBreed_Backend_2023.DAL;
using DogBreed_Backend_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace DogBreed_Backend_2023.Controllers
{
  public class ActivitiesController : Controller
  {
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
      DogBreedRepository repo = new DogBreedRepository();

      [HttpPost("CreateActivity")]
      public ActivityModel AddActivity(int id, string title, string description)
      {
        ActivityModel newActivity = new ActivityModel
        {
          Id = id,
          Title = title,
          Description = description
        };
        return repo.AddActivity(newActivity);
      }
      [HttpGet("GetAllActivities")]
      public List<ActivityModel> GetAll()
      {
        return repo.GetAllActivities();
      }
      [HttpGet("GetActivitiesById")]
      public ActivityModel GetById(int id)
      {
        return repo.FindActivityById(id);
      }
      [HttpPut("UpdateActivities")]
      public HttpResponseMessage UpdateActivity(int id, string title, string description)
      {
        ActivityModel activityToUpdate = new ActivityModel
        {
          Id = id,
          Title = title,
          Description = description
        };

        try
        {
          if (repo.UpdateActivity(activityToUpdate) == true)
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
      [HttpDelete("DeleteActivity")]
      public HttpResponseMessage DeleteById(int id)
      {
        try
        {
          if (repo.DeleteById(id) == true)
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
}
