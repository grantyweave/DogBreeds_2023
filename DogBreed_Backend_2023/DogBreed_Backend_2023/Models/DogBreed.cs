namespace DogBreed_Backend_2023.Models
{
  public class DogBreed
  {
    public int id { get; set; }
    public string breed { get; set; }
    public string origin { get; set; }
    public string url { get; set; }

    public Meta meta { get; set; }
  

  }
}
