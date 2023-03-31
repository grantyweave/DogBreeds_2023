using DogBreed_Backend_2023.Models;
using Microsoft.EntityFrameworkCore;


namespace DogBreed_Backend_2023.DAL
{
  public class UsersRepository
  {
    private BreedContext _context = new BreedContext();

    public Users AddNewUser(Users newUser)
    {
      _context.Users.Add(newUser);
      _context.SaveChanges();
      return GetLatestUser();
    }
    public Users GetLatestUser()
    {
      return _context.Users.OrderByDescending(x => x.Id).FirstOrDefault();
    }

    public List<Users> GetAllUsers()
    {
      return _context.Users.ToList();
    }

    public Users FindByUserLastName(string userName)
    {
      // AsNoTracking will not lock the ID allowing updating it after finding it
      return _context.Users.AsNoTracking().FirstOrDefault(x => x.LastName == userName);
    }
    public Users FindByUserId(int id)
    {
      // AsNoTracking will not lock the ID allowing updating it after finding it
      return _context.Users.AsNoTracking().FirstOrDefault(x => x.Id == id);
    }
    public bool DeleteUserById(int id)
    {
      Users userToDelete = FindByUserId(id);

      if (userToDelete == null)
      {
        return false;
      }
      else
      {
        _context.Users.Remove(userToDelete);
        _context.SaveChanges();
        return true;
      }
    }
    public bool UpdateUser(Users userToUpdate)
    {
      if (FindByUserId(userToUpdate.Id) == null)
      {
        return false;
      }
      _context.Users.Update(userToUpdate);
      _context.SaveChanges();
      return true;
    }
  }
}
