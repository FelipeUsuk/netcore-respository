using Repository.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class BookMemoryRepository : MemoryRepositoryBase<BookEntity, int> , IBookRepository<BookEntity, int>
    {
        //0 code because inherites for abstract repository has all default implementation
    }
}
