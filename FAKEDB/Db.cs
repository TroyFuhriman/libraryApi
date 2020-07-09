using System.Collections.Generic;
using bookapi.Models;

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

  }
}