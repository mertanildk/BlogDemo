﻿using Entity.Concrete;

namespace Business.Abstract
{
    public interface IContactService
    {
        void Add(Contact contact);
        void Delete(Contact contact);
        void Update(Contact contact);
        Contact GetById(int id);
        List<Contact> GetAll();

    }
}
