using BookApi2.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApi2.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int id);

        Task<Book> Create(Book book);

        Task Update (Book book);

        Task Delete(int id);  
    }
}
