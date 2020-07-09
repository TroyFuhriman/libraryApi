using System;
using System.ComponentModel.DataAnnotations;

namespace bookapi.Models
{
  public class Book
  {
    [Required]
    public string Id { get; set; }
    [Required]
    public string Author { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public bool Available { get; set; }

    public Book(string author, string title, string description)
    {
      Id = Guid.NewGuid().ToString();
      Author = author;
      Title = title;
      Description = description;
      Available = true;
    }
    public Book()
    {
      Id = Guid.NewGuid().ToString();
    }


  }

}