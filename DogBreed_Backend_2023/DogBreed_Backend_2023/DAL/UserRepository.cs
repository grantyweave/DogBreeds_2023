using DogBreed_Backend_2023.Models;
using Microsoft.EntityFrameworkCore;


namespace DogBreed_Backend_2023.DAL
{
  public class UserRepository
  {
    private BreedContext _context = new BreedContext();

    public User AddNewUser(User newUser)
    {
      _context.Users.Add(newUser);
      _context.SaveChanges();
      return GetLatestUser();
    }
    public User GetLatestUser()
    {
      return _context.Users.OrderByDescending(x => x.Id).FirstOrDefault();
    }
  }
}
