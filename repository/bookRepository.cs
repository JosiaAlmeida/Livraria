using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.interfaces;
using biblioteca.models;

namespace biblioteca.repository
{
    public class BookRepository : IBook
    {
        public List<Book> _book = new List<Book>();

        public List<Book> find()
        {
            return _book.ToList();
        }

        public Book post(Book book)
        {
            this._book.Add(book);
            return book;
        }
        public Book put(Book book, int id)
        {
            Book data = this._book.Find(x => x.id == id);
            return data;
        }

        public void Delete(int id)
        {
            this._book.RemoveAt(id);
        }
    }
}