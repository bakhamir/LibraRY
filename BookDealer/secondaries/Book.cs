using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDealer.secondaries
{
    public  class Book : Publishing<Book>
    {
        public Book(string Publishing)
        {
            this.publishment = Publishing;
        }

        public DateTime releaseDate { get; set; }
        public string publishment { get; set; }

        public Book CreateBook()
        {
            Book newBook = new Book(publishment);
            publishment = Console.ReadLine();
            newBook.name = Console.ReadLine();
            newBook.author = Console.ReadLine();
            newBook.releaseDate = Convert.ToDateTime(Console.ReadLine());
            Catalogue.Add(newBook);
            return newBook;
        }
        public override void ShowInfo()
        {
            Console.WriteLine(Catalogue);
        }
    }
}
