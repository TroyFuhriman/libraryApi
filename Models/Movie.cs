using System;
using System.ComponentModel.DataAnnotations;

namespace libraryApi.Models
{
  public class Movie
  {
    [Required]
    public string Id { get; set; }
    [Required]
    public string Director { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public bool Available { get; set; }

    public Movie(string director, string title, string description)
    {
      Id = Guid.NewGuid().ToString();
      Director = director;
      Title = title;
      Description = description;
      Available = true;
    }
    public Movie()
    {
      Id = Guid.NewGuid().ToString();
      Available = true;

    }
  }
}