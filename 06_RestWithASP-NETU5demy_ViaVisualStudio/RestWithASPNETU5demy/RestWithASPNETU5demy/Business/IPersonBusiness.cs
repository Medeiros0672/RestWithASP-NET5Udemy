using RestWithASPNETU5demy.Models;
using System.Collections.Generic;

namespace RestWithASPNETU5demy.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
