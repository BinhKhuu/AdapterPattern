using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System.Globalization;
using System.Text.Json;
using System.Xml.Linq;

var booksService = new BooksService();
var books = booksService.GetBooks();

foreach (var book in books)
{
    Console.WriteLine($"{book.Title} {book.Author}");
}

Console.ReadLine();