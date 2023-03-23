using DogBreed_Backend_2023.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace DogBreed_Backend_2023.DAL
{
  public class UserRepository
  {
    private UserContext _dbContext = new UserContext();

    public List<User> GetAllUsers()
    {
      return _dbContext.Users.ToList();
    }
    public User FindByUserName(string userName)
    {
      // AsNoTracking will not lock the ID allowing updating it after finding it
      return _dbContext.Users.AsNoTracking().FirstOrDefault(x => x.UserName == userName);
    }

    //FAVORITES

    public void AddFavoriteBreed(string userName, int breedId)
    {
      var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
      if (user != null)
      {
        user.FavoriteBreeds.Concat(new[] { breedId });
        _dbContext.SaveChanges();
      }
    }
    public List<int> GetAllUserFavoriteBreeds(string userName)
    {
      var usersBreeds = _dbContext.Users.FirstOrDefault(x => x.UserName == userName).FavoriteBreeds.ToList();
      return usersBreeds;
    }
    public void DeleteFavoriteBreed(string userName, int breedId)
    {
      var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);

      if (user != null)
      {
        user.FavoriteBreeds.Except(new[] { breedId });
        _dbContext.SaveChanges();
      }
    }

    //ACTIVITIES

    public ActivityModel AddActivity(ActivityModel newActivity)
    {
      _dbContext.Activities.Add(newActivity);
      _dbContext.SaveChanges();
      return GetLatestActivity();
    }
    public List<ActivityModel> GetAllActivities()
    {
      return _dbContext.Activities.ToList();
    }
    public ActivityModel FindActivityById(int id)
    {
      // AsNoTracking will not lock the ID allowing updating it after finding it
      return _dbContext.Activities.AsNoTracking().FirstOrDefault(x => x.Id == id);
    }
    private ActivityModel GetLatestActivity()
    {
      return _dbContext.Activities.OrderByDescending(x => x.Id).FirstOrDefault();
    }
    public bool UpdateActivity(ActivityModel activitiesToEdit)
    {
      if (FindActivityById(activitiesToEdit.Id) == null)
      {
        return false;
      }
      _dbContext.Activities.Update(activitiesToEdit);
      _dbContext.SaveChanges();
      return true;
    }
    public bool DeleteById(int id)
    {
      ActivityModel activities = FindActivityById(id);
      if (activities == null)
      {
        return false;
      }
      _dbContext.Activities.Remove(activities);
      _dbContext.SaveChanges();
      return true;
    }
  }
}
