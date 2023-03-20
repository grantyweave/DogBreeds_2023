using DogBreed_Backend_2023.DAL;
using DogBreed_Backend_2023.Models;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
  options.AddPolicy(name: "CorsPolicy",
    builder =>
    {
      builder.SetIsOriginAllowed(origin => true);
      builder.AllowAnyMethod();
      builder.AllowAnyHeader();
      builder.AllowCredentials();
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();

using (var context = new BreedContext())
{
  context.Database.EnsureCreated();

  var testBlog = context.Activities.FirstOrDefault(b => b.Title == "Go on a walking tour of a city");
  if (testBlog == null)
  {
    context.Activities.AddRange(
      new[]
      {
      new ActivityModel  { Title = "Go on a walking tour of a city", Description = "One of the best ways to explore a new city is by foot, and a savvy guide can show you and your dog the secret local spots you might otherwise overlook. Free Walking Tour in a city near you" },
      new ActivityModel { Title = "Go for a run or jog together", Description = "Parks and towns are not just for walking, so lace up, leash up and hit the ground running with your pooch by your side. It’s easy to get started as a lone pair, or visit your local FREE park run to join in the fun with other runners and furry friends. Please be wary of the weather and do not take your dog out in hot weather." },
      new ActivityModel { Title = "Explore a National Park", Description = "Planning a day out exploring the countryside? Take your dog with you! The UK’s 15 National Parks are some of our most breath-taking and treasured landscapes, and offer endless opportunities for quality time with your canine companion." }
      });
  }
  context.SaveChanges();
}

app.Run();
