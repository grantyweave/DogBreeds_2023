using DogBreed_Backend_2023.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace DogBreed_Backend_2023.DAL
{
  public class UserRepository
  {

    private BreedContext _context = new BreedContext();

    public Users LoginUser(Users newUser)
    {

      if (newUser.FirstName == "null")
      {
        Users getUser = _context.Users.FirstOrDefault(x => x.Email == newUser.Email & x.Password == newUser.Password);
        return getUser;
      }
      else
      {
        _context.Users.Add(newUser);
        _context.SaveChanges();
        return newUser;
      }

    }

    public List<Users> GetAllUsers()
    {
      return _context.Users.ToList();
    }

    public Users getUserById(int id)
    {
      return _context.Users.FirstOrDefault(x => x.Id == id);
    }


    public void UpdateUser(string firstName, string lastName, string email, string password, bool isAdmin, Users user)
    {
      Users userToUpdate = _context.Users.FirstOrDefault(x => x.Id == user.Id);

      userToUpdate.FirstName = firstName;
      userToUpdate.LastName = lastName;
      userToUpdate.Email = email;
      userToUpdate.Password = password;
      userToUpdate.IsAdmin = isAdmin;
      _context.Users.Update(userToUpdate);
      _context.SaveChanges();
    }

    public void DeleteUser(Users userToUpdate)
    {
      _context.Users.Remove(userToUpdate);
      _context.SaveChanges();
    }
  }
}
