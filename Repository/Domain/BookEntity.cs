using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Domain
{
    public class BookEntity : EntityBase<int>
    {
        public string Title { get; private set; }

        public string Author { get; private set; }

        public bool Rented{ get; private set; }

        public BookEntity(string title, string author)
        {
            Title = title;
            Author = author;
            Rented = false;
        }
        public bool Rent()
        {
            if (!Rented)
            {
                Rented = true;
                return true;
            }
            return false;
        }

        public bool ReturnRent()
        {
            if (Rented)
            {
                Rented = false;
                return true;
            }
            return false;
        }
    }
}
