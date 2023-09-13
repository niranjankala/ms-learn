using System.Collections.Generic;
using Summaries.Data.Models;
namespace Summaries.Data.Services
{

    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}