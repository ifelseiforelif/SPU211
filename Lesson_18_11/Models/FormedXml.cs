using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson_18_11.Models
{
    public class FormedXml
    {
        public void CreateBooks(XmlDocument doc, XmlElement root, List<Book> lb)
        {
            if (lb.Count > 0)
            {
                foreach(var book in lb) 
                {
                    XmlElement book1 = doc.CreateElement("Book");
                    book1.SetAttribute("genre", book.Genre);
                    root.AppendChild(book1);
                    XmlElement title1 = doc.CreateElement("Title");
                    title1.InnerText = book.Title;

                    XmlElement author1 = doc.CreateElement("Author");
                    author1.InnerText = book.Author;

                    XmlElement year1 = doc.CreateElement("Year");
                    year1.InnerText =book.Year.ToString();
                    book1.AppendChild(title1);
                    book1.AppendChild(author1);
                    book1.AppendChild(year1);
                }
                
            }
            
            
        }
    }
}
