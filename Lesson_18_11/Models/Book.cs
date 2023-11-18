using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18_11.Models
{
    public class Book
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Book(string a, string t, string g, int y)
        {
            Author = a;
            Title = t;
            Genre = g; 
            Year = y;
        }
    }
}
