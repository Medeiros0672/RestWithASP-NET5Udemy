using RestWithASPNETU5demy.Models;
using System.Collections.Generic;

namespace RestWithASPNETU5demy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
