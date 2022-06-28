using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.models;

namespace biblioteca.interfaces
{
    public interface IBook
    {
        public List<Book> find();
        public Book post(Book book);
        public Book put(Book book, int id);
        public void Delete(int id);
    }
}