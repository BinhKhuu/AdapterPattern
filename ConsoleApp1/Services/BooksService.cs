using ConsoleApp1.Adapters;
using ConsoleApp1.Interface;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Services
{
    public class BooksService : IBooksService
    {
        private BooksDataService _booksDataService;
        private ILibraryServiceXMLAdapater _libraryServiceXMLAdapter;
        public BooksService() 
        {
            _booksDataService = new BooksDataService();
            _libraryServiceXMLAdapter = new LibraryServiceAdapter();
        }
        public List<Books> GetBooks()
        {
            var requestData = XElement.Parse(_booksDataService.GetBooksXML());
            var libraryBooksRequest = XElement.Parse(_libraryServiceXMLAdapter.GetBooks());
            var books = ParseBooks(requestData);

            var libraryBooks = ParseBooks(libraryBooksRequest);

            var allBooks = books.Concat(libraryBooks).ToList();
            return allBooks;
        }

        private List<Books> ParseBooks(XElement requestData)
        {
            var books = requestData.Elements("book").Select(b => new Books
            {
                Author = b.Element("author") is null ? string.Empty : b.Element("author").Value,
                Title = b.Element("title") is null ? string.Empty : b.Element("title").Value,
                Genre = b.Element("genre") is null ? string.Empty : b.Element("genre").Value,
                Price = b.Element("price") is null ? 0 : (double)b.Element("price"),
                PublishDate = b.Element("publish_date") is null ? null : DateOnly.Parse(b.Element("publish_date").Value),
                Description = b.Element("description") is null ? string.Empty : b.Element("description").Value,
            })
            .ToList();

            return books;
        }
    }
}
