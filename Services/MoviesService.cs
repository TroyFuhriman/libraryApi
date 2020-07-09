using System;
using System.Collections.Generic;
using catapi.FAKEDB;
using libraryApi.Models;

namespace libraryApi.services
{
  public class MovieService
  {
    internal IEnumerable<Movie> Get()
    {
      return fakeDb.Movies;
    }

    internal Movie getById(string id)
    {
      var found = fakeDb.Movies.Find(b => b.Id == id);
      if (found == null)
      {
        throw new Exception("bad id bro");
      }
      return found;
    }

    internal Movie Create(Movie newMovie)
    {
      fakeDb.Movies.Add(newMovie);
      return newMovie;
    }

    internal object Edit(Movie editMovie, string id)
    {
      var original = fakeDb.Movies.Find(b => b.Id == id);
      if (original == null) { throw new Exception("no way dude"); }
      editMovie.Id = original.Id;
      editMovie.Director = editMovie.Director != null ? editMovie.Director : original.Director;
      editMovie.Title = editMovie.Title != null ? editMovie.Title : original.Title;
      editMovie.Description = editMovie.Description != null ? editMovie.Description : original.Description;
      fakeDb.Movies.Remove(original);
      fakeDb.Movies.Add(editMovie);
      return editMovie;
    }

    internal IEnumerable<Movie> GetAvail()
    {
      var found = fakeDb.Movies.FindAll(b => b.Available == true);
      return found;
    }

    internal object Delete(string id)
    {
      var found = fakeDb.Movies.Find(b => b.Id == id);
      if (found == null) { throw new Exception("nah fam that aint it"); }
      fakeDb.Movies.Remove(found);
      return found;
    }
  }
}