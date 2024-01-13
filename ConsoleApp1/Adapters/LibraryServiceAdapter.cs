using ConsoleApp1.Interface;
using ConsoleApp1.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1.Adapters
{
    internal class LibraryServiceAdapter : ILibraryServiceXMLAdapater
    {
        private LibraryService _libraryService;
        public LibraryServiceAdapter() 
        {
            _libraryService = new LibraryService();
        }

        // return xml
        public string GetBooks()
        {
            var booksJSON = _libraryService.GetBooks();
            XmlDocument doc = JsonConvert.DeserializeXmlNode(booksJSON);
            return doc.InnerXml.ToString();

            // not formatted correctly Todo: format it correctly an remove newton soft
            //using (var reader = JsonReaderWriterFactory.CreateJsonReader(Encoding.ASCII.GetBytes(booksJSON), new XmlDictionaryReaderQuotas()))
            //{
            //    var catalog = XElement.Load(reader);
            //    return catalog.ToString();
            //}
        }
    }
}
