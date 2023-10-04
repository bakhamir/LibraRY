using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDealer.secondaries
{
    internal class Article : Publishing<Article>
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public DateTime releaseDate { get; set; }

        public Article CreateArticle()
        {
            Article newArticle = new Article();
            newArticle.name = Console.ReadLine();
            newArticle.author = Console.ReadLine();
            newArticle.releaseDate = Convert.ToDateTime(Console.ReadLine());
            newArticle.Title = Console.ReadLine();
            newArticle.Id = Int32.Parse(Console.ReadLine());
            Catalogue.Add(newArticle);
            return newArticle;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}",this.name,this.author,this.Title,this.Id,this.releaseDate);
        }
    }
}
