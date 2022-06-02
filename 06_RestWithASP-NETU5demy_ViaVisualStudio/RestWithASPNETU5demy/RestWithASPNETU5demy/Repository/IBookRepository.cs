using RestWithASPNETU5demy.Models;
using System.Collections.Generic;

namespace RestWithASPNETU5demy.Repository
{
    public interface IBookRepository
    {
        Book Create(Book person);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book person);
        void Delete(long id);
        bool Exists(long id);
    }
}
