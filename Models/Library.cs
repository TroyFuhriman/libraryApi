using System;
using System.ComponentModel.DataAnnotations;

namespace libraryApi.Models
{
  public class Library
  {
    [Required]
    public string Id { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }

    public Library(string name, string location, string description)
    {
      Id = Guid.NewGuid().ToString();
      Location = location;
      Name = name;
      Description = description;
    }
    public Library()
    {
      Id = Guid.NewGuid().ToString();
    }
  }
}