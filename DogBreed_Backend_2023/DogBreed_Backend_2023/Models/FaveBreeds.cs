namespace DogBreed_Backend_2023.Models
{
  public class FaveBreeds
  {
    public int Id { get; set; }
    public string Breed { get; set; }
    public string Origin { get; set; }
    public string Url { get; set; }

    public string Img { get; set; }

    public string Notes { get; set; }
    public int UserId { get; set; }
    public Users User { get; set; }
  }
}
