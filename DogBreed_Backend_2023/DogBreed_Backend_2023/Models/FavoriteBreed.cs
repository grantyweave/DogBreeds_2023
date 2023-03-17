namespace DogBreed_Backend_2023.Models
{
  public class FavoriteBreed
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Password { get; set; }
    public int BreedId { get; set; }
  }
}
