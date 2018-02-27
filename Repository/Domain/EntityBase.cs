using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Domain
{
    public abstract class EntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}
