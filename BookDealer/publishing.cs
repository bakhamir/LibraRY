using System;
using BookDealer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDealer
{
    public abstract class Publishing<T>
    {
        public string name { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine("NO DATA");
        }
        public List<T> Catalogue { get; set; }
        
    }
}
