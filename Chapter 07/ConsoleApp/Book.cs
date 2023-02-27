using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Creation { get; set; }
        public Author Author { get; set; }
        public string Summary { get; set; }
        public int IsbnNumber { get; set; }
    }

    public class Author
    {
    }
}
