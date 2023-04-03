//using DogBreed_Backend_2023.Models;
//using Microsoft.EntityFrameworkCore;
//using System.Diagnostics;
//using System.Linq;

//namespace DogBreed_Backend_2023.DAL
//{
//  public class DogBreedRepository
//  {
//    private BreedContext _dbContext = new BreedContext();
 
//    //DOG BREED

//    public List<DogBreed> GetAllBreeds()
//    {
//      return _dbContext.DogBreeds.ToList();
//    }
//    public DogBreed FindById(int id)
//    {
//      // AsNoTracking will not lock the ID allowing updating it after finding it
//      return _dbContext.DogBreeds.AsNoTracking().FirstOrDefault(x => x.Id == id);
//    }

//    //userId, userFavorites (list of ids from api) in database 

//    //FAVORITES


    //public User AddFavoriteBreed(User newFavoriteBreed)
    //{ //WIP
    // // _dbContext.FavoriteBreeds.Add(newFavoriteBreed);
    //  _dbContext.SaveChanges();
    //  return newFavoriteBreed;
    //}
    //public List<int> GetAllUserFavoriteBreeds(int userId)
    //{
    //  var usersBreeds = _dbContext.FavoriteBreeds.FirstOrDefault(x => x.UserName == userId).FavoriteBreeds.ToList();
    //  return usersBreeds;
    //}
    //public void DeleteFavoriteBreed(int userId, int breedId)
    //{ //WIP
    //  var favorites = _dbContext.FavoriteBreeds.FirstOrDefault(x => x.UserName == userId).FavoriteBreeds.ToList();
    //  favorites.Remove(breedId);


//    //  if (favorites != null)
//    //  {
//    //    _dbContext.FavoriteBreeds.Remove(favorites);
//    //    _dbContext.SaveChanges();
//    //  }
//    //}

//    //ACTIVITIES

//    public ActivityModel AddActivity(ActivityModel newActivity)
//    {
//      _dbContext.Activities.Add(newActivity);
//      _dbContext.SaveChanges();
//      return GetLatestActivity();
//    }
//    public List<ActivityModel> GetAllActivities()
//    {
//      return _dbContext.Activities.ToList();
//    }
//    public ActivityModel FindActivityById(int id)
//    {
//      // AsNoTracking will not lock the ID allowing updating it after finding it
//      return _dbContext.Activities.AsNoTracking().FirstOrDefault(x => x.Id == id);
//    }
//    private ActivityModel GetLatestActivity()
//    {
//      return _dbContext.Activities.OrderByDescending(x => x.Id).FirstOrDefault();
//    }
//    public bool UpdateActivity(ActivityModel activitiesToEdit)
//    {
//      if (FindActivityById(activitiesToEdit.Id) == null)
//      {
//        return false;
//      }
//      _dbContext.Activities.Update(activitiesToEdit);
//      _dbContext.SaveChanges();
//      return true;
//    }
//    public bool DeleteById(int id)
//    {
//      ActivityModel activities = FindActivityById(id);
//      if (activities == null)
//      {
//        return false;
//      }
//      _dbContext.Activities.Remove(activities);
//      _dbContext.SaveChanges();
//      return true;
//    }
//  }
//}
