using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace LibraryWPF
{
    public class BookStore
    {
        public enum SearchCriteria { All, Genre, Price, Author }
        public void AddBook(Book b)
        {
            try
            {
                XDocument bookDoc = XDocument.Load("Books.xml");
                XElement root = bookDoc.Element("catalog");
                root.Add(new XElement("book",
                    new XElement("author", b.Author),
                    new XElement("title", b.Name),
                    new XElement("genre", b.Genre),
                    new XElement("price", b.Price),
                    new XElement("description", b.Description)));

                bookDoc.Save("Books.xml");
            }

            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<Book> GetBooks(SearchCriteria s, string criteria = "")
        {
            Predicate<XElement> p;
            switch (s)
            {
                case SearchCriteria.All:
                    p = new Predicate<XElement>(x => true);
                    break;

                case SearchCriteria.Genre:
                    p = new Predicate<XElement>(b =>
                    {
                        if(((string)b.Element("genre")).Contains(criteria))
                            return true;
                        return false;
                    });
                    break;

                case SearchCriteria.Price:
                    p = new Predicate<XElement>(b =>
                    {
                        if (((string)b.Element("price")) == criteria)
                            return true;
                        return false;
                    });
                    break;

                default:
                    p = new Predicate<XElement>(b =>
                    {
                        if (((string)b.Element("author")).Contains(criteria))
                            return true;
                        return false;
                    });
                    break;
            }

            try
            {
                XDocument bookDoc = XDocument.Load("Books.xml");
                XElement root = bookDoc.Element("catalog");

                var books = from book in root.Descendants("book")
                            where p(book)
                            select new Book
                            {
                                Name = (string)book.Element("title"),
                                Genre = (string)book.Element("genre"),
                                Price = (string)book.Element("price"),
                                Description = (string)book.Element("description"),
                                Author = (string)book.Element("author")
                            };

                return books.ToList();
            }

            catch(System.IO.FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
    }
}
