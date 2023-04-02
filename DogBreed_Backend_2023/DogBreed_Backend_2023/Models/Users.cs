namespace DogBreed_Backend_2023.Models
{
  public class Users
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public ICollection<FaveBreeds>? Favorites { get; }
  }
}
