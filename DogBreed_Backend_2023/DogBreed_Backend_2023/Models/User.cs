using Microsoft.EntityFrameworkCore;

namespace DogBreed_Backend_2023.Models
{
  [Keyless]
  public class User
  {
    public int Id { get; set; }
    public int UserName { get; set; }
    public string Password { get; set; }
    public List<int> FavoriteBreeds { get; set; }
  }
}
