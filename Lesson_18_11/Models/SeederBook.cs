using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18_11.Models
{
    public class SeederBook
    {
        public Book GetBook()
        {
            Console.WriteLine("Enter Title: ");
            string? title = Console.ReadLine();
            Console.WriteLine("Enter Author: ");
            string? author = Console.ReadLine();
            Console.WriteLine("Enter Genre: ");
            string? genre = Console.ReadLine();
            Console.WriteLine("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            return new Book(author,title, genre,year);
        }
    }
}
