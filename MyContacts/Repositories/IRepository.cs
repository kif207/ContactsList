using System.Collections.Generic;

namespace MyContacts.Repositories
{
    public interface IRepository<TEnt> where TEnt : class
    {
        IEnumerable<TEnt> Get();        
    }
}
