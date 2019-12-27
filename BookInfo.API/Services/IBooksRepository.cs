using Books.Api.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.Api.Services
{
    public interface IBooksRepository
    {
        //IEnumerable<Book> GetBooks();

        //Entities.Book GetBook(Guid id);

        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book> GetBookAsync(Guid id);
        void AddBook(Entities.Book bookToAdd);
        void DeleteBook(Book book);
        void UpdateBook(Book book);
        Task<bool> SaveChangesAsync();
    }
}
