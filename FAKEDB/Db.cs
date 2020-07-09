using System.Collections.Generic;

using libraryApi.Models;

namespace catapi.FAKEDB

{
  public static class fakeDb
  {
    public static List<Book> Books { get; set; } = new List<Book>(){
        new Book("Brandon Sanderson", "Way of Kings", "super long epic fantasy"),
        new Book("Brandon Sanderson", "mistborn", "what happens if the bad guy wins and rules for 1000 years"),
        new Book("Brandon Sanderson", "Rithmatist", "magic users can use chalk to bring chalk creatures to life"),
        new Book("Brandon Sanderson", "Steelheart", "If half the population got super powers, but they were all evil")
      };

    public static List<Movie> Movies { get; set; } = new List<Movie>(){
        new Movie("M Night Shyamalan", "The Last Airbender", "better than the cartoon"),
        new Movie("M Night Shyamalan", "The Village", "creepy dude doing creepy stuff"),
        new Movie("M Night Shyamalan", "The Sixth Sense", "I see dead people"),
        new Movie("M Night Shyamalan", "Glass", "Personality disorder I think, didnt see it")
      };

  }
}