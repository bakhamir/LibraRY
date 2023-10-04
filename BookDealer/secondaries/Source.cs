using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDealer.secondaries
{
    internal class Source : Publishing<Source>
    {
        public string link { get; set; }
        public string annotation { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2} {3}",name,author,link,annotation);
        }
        public Source CreateBook()
        {
            Source newSource = new Source();
            newSource.name = Console.ReadLine();
            newSource.author = Console.ReadLine();
            newSource.annotation = Console.ReadLine();
            newSource.link = Console.ReadLine();
            Catalogue.Add(newSource);
            return newSource;
        }
    }
}
