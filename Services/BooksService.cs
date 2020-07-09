using System;
using System.Collections.Generic;

using catapi.FAKEDB;
using libraryApi.Models;

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

    internal object Edit(Book editBook, string id)
    {
      var original = fakeDb.Books.Find(b => b.Id == id);
      if (original == null) { throw new Exception("no way dude"); }
      editBook.Id = original.Id;
      editBook.Author = editBook.Author != null ? editBook.Author : original.Author;
      editBook.Title = editBook.Title != null ? editBook.Title : original.Title;
      editBook.Description = editBook.Description != null ? editBook.Description : original.Description;
      fakeDb.Books.Remove(original);
      fakeDb.Books.Add(editBook);
      return editBook;
    }

    internal IEnumerable<Book> GetAvail()
    {
      var found = fakeDb.Books.FindAll(b => b.Available == true);
      return found;
    }

    internal object Delete(string id)
    {
      var found = fakeDb.Books.Find(b => b.Id == id);
      if (found == null) { throw new Exception("nah fam that aint it"); }
      fakeDb.Books.Remove(found);
      return found;
    }
  }
}