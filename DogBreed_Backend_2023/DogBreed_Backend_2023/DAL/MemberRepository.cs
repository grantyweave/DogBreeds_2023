using DogBreed_Backend_2023.Models;
using System.Diagnostics.Metrics;

namespace DogBreed_Backend_2023.DAL
{
  public class MemberRepository
  {
    private BreedContext _Db = new BreedContext();

    public void AddMember(Member member)
    {
      _Db.Team.Add(member);
      _Db.SaveChanges();
    }
  }
}
