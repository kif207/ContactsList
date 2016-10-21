using System;
using System.Collections.Generic;
using System.Linq;
using MyContacts.Models;

namespace MyContacts.Repositories
{
    public class ContactRepository : IRepository<Contact>
    {
        // Needs Dependency Injection Here 
        public ContactsService _contactsService { get; set; }

        public ContactRepository()
        {
            _contactsService = new ContactsService();
        }

        public IEnumerable<Contact> Get()
        {
           return _contactsService.GetAll();
        }
    }
}