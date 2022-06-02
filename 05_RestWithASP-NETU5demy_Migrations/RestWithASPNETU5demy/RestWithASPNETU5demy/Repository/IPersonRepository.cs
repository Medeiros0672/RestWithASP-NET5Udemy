using RestWithASPNETU5demy.Models;
using System.Collections.Generic;

namespace RestWithASPNETU5demy.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
