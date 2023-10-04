using BookDealer;
using BookDealer.secondaries;
namespace LibraRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("asd");
            book.CreateBook();
            book.ShowInfo();
        }
    }
}
