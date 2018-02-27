using Repository.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{

    public interface IRepository<TDomain, TKey> where TDomain : EntityBase<TKey>
    {
        TDomain FindById(TKey id);
        IEnumerable<TDomain> FindAll();
        IEnumerable<TDomain> Find(Func<TDomain, bool> query);
        void Update(TDomain domain);
        void Delete(TKey id);
        void Insert(TDomain domain);
    }
}

