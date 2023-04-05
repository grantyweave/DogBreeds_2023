using System.ComponentModel.DataAnnotations.Schema;

namespace DogBreed_Backend_2023.Models
{
  public class Favorite
  {
    public int Id { get; set; }
    public DogBreed FavoriteBreed { get; set; }
    public string Notes { get; set; }
    public int UserId { get; set; }

    //[ForeignKey("UserId")]
    public virtual User User { get; set; }
  }
}
