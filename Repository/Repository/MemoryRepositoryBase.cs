using Repository.Domain;
using Repository.Mocks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Repository.Repository
{
    public abstract class MemoryRepositoryBase<TDomain, TKey> : IRepository<TDomain, TKey> where TDomain : EntityBase<TKey>
    {
        //Use to simulate a in memory repository
        protected MemoryMock<TDomain, TKey> MemMock = new MemoryMock<TDomain, TKey>();
        public virtual void Delete(TKey id)
        {
            if (MemMock.Memory.ContainsKey(id))
                MemMock.Memory.Remove(id);
        }

        public virtual IEnumerable<TDomain> Find(Func<TDomain, bool> query)
        {
            return MemMock.Memory.Values.ToList().Where(query);
        }

        public virtual IEnumerable<TDomain> FindAll()
        {
            return MemMock.Memory.Values;
        }

        public virtual TDomain FindById(TKey id)
        {
            if (MemMock.Memory.ContainsKey(id))
                return MemMock.Memory[id];
            else
                return null;
        }

        public virtual void Insert(TDomain domain)
        {
            if (MemMock.Memory.ContainsKey(domain.Id))
                throw new Exception("Duplicated key error");
            else
                MemMock.Memory.Add(domain.Id, domain);
        }

        public virtual void Update(TDomain domain)
        {
            if (MemMock.Memory.ContainsKey(domain.Id))
                MemMock.Memory[domain.Id] = domain;
            else
                throw new Exception("Invalkid key to update error");
        }
    }
}
