using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyContacts.Models;
using MyContacts.Repositories;

namespace MyContacts.Controllers
{
    public class ContactController : ApiController
    {
        private IRepository<Contact> _repository;
 
        //Needs Dependency Injection here "public ContactController (IRepository<Contact> repo)"
        public ContactController()
	    {
            _repository = new ContactRepository();
        }

        [Route("api/Contact")]
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            try
            {
                return _repository.Get();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }
    }
}
