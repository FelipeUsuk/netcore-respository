using Repository.Domain;
using Repository.Repository;
using System;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var csharp1Book = new BookEntity("C# 1", "Writer") { Id = 1 };
            var csharp2Book = new BookEntity("C# 2", "Blogger") { Id = 2 };
            var csharp3Book = new BookEntity("C# 3", "Writer") { Id = 3 };

            var repository = new BookMemoryRepository();

            repository.Insert(csharp1Book);
            repository.Insert(csharp2Book);
            repository.Insert(csharp3Book);


            var book = repository.FindById(1);

            Console.WriteLine($"{book.Title}");


            //You can having fun here

            //
            Console.ReadKey();
        }
    }
}
