using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogBreed_Backend_2023.Models
{
  [Keyless]
  [NotMapped]
  public class Meta
  {
    
    public string coat { get; set; }

  }
}
