﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _dal;

        public ContactManager(IContactDal dal)
        {
            _dal = dal;
        }

        public void ContactAdd(Contact contact)
        {
            _dal.Insert(contact);
        }
    }
}
