using System;
using System.Collections.Generic;
using bookapi.Models;
using catapi.FAKEDB;

namespace libraryApi.services
{
  public class BookService
  {
    internal IEnumerable<Book> Get()
    {
      return fakeDb.Books;
    }

    internal Book getById(string id)
    {
      var found = fakeDb.Books.Find(b => b.Id == id);
      if (found == null)
      {
        throw new Exception("bad id bro");
      }
      return found;
    }

    internal Book Create(Book newBook)
    {
      fakeDb.Books.Add(newBook);
      return newBook;
    }
  }
}