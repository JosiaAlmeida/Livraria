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
            return this._book;
        }

        public Book post(Book book)
        {
            try
            {
                this._book.Add(book);
                return book;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
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