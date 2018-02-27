using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mocks
{
    public class MemoryMock <TDomain, Tkey>
    {
       public Dictionary<Tkey, TDomain> Memory = new Dictionary<Tkey, TDomain>();
    }
}
