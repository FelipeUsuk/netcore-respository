using Repository.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public interface IBookRepository<TDomain, TKey> : IRepository<TDomain, TKey> where TDomain : EntityBase<TKey>
    {
        //0 code because it's a simple example with no specific implementation for book repository
    }
}
