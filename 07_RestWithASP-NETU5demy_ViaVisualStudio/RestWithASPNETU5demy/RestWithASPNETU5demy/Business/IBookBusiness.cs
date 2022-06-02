﻿using RestWithASPNETU5demy.Models;
using System.Collections.Generic;

namespace RestWithASPNETU5demy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}
