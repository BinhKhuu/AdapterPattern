﻿using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class LibraryService
    {
        public LibraryService() { }

        // returns JSON
        public string GetBooks()
        {
            //return @"{""Author"":""Gambardella, Matthew"",""Title"":""XML Developer\u0027s Guide"",""Genre"":""Computer"",""Price"":44.95,""PublishDate"":""2000-10-01""}";
            return @"{
  ""catalog"": {
    ""book"": [
      {
        ""author"": ""Gambardella, Matthew"",
        ""title"": ""XML Developer's Guide"",
        ""genre"": ""Computer"",
        ""price"": 44.95,
        ""publish_date"": ""2000-10-01"",
        ""description"": ""An in-depth look at creating applications \n      with XML.""
      },
      {
        ""author"": ""Ralls, Kim"",
        ""title"": ""Midnight Rain"",
        ""genre"": ""Fantasy"",
        ""price"": 5.95,
        ""publish_date"": ""2000-12-16"",
        ""description"": ""A former architect battles corporate zombies, \n      an evil sorceress, and her own childhood to become queen \n      of the world.""
      },
      {
        ""author"": ""Corets, Eva"",
        ""title"": ""Maeve Ascendant"",
        ""genre"": ""Fantasy"",
        ""price"": 5.95,
        ""publish_date"": ""2000-11-17"",
        ""description"": ""After the collapse of a nanotechnology \n      society in England, the young survivors lay the \n      foundation for a new society.""
      },
      {
        ""author"": ""Corets, Eva"",
        ""title"": ""Oberon's Legacy"",
        ""genre"": ""Fantasy"",
        ""price"": 5.95,
        ""publish_date"": ""2001-03-10"",
        ""description"": ""In post-apocalypse England, the mysterious \n      agent known only as Oberon helps to create a new life \n      for the inhabitants of London. Sequel to Maeve \n      Ascendant.""
      },
      {
        ""author"": ""Corets, Eva"",
        ""title"": ""The Sundered Grail"",
        ""genre"": ""Fantasy"",
        ""price"": 5.95,
        ""publish_date"": ""2001-09-10"",
        ""description"": ""The two daughters of Maeve, half-sisters, \n      battle one another for control of England. Sequel to \n      Oberon's Legacy.""
      },
      {
        ""author"": ""Randall, Cynthia"",
        ""title"": ""Lover Birds"",
        ""genre"": ""Romance"",
        ""price"": 4.95,
        ""publish_date"": ""2000-09-02"",
        ""description"": ""When Carla meets Paul at an ornithology \n      conference, tempers fly as feathers get ruffled.""
      },
      {
        ""author"": ""Thurman, Paula"",
        ""title"": ""Splish Splash"",
        ""genre"": ""Romance"",
        ""price"": 4.95,
        ""publish_date"": ""2000-11-02"",
        ""description"": ""A deep sea diver finds true love twenty \n      thousand leagues beneath the sea.""
      },
      {
        ""author"": ""Knorr, Stefan"",
        ""title"": ""Creepy Crawlies"",
        ""genre"": ""Horror"",
        ""price"": 4.95,
        ""publish_date"": ""2000-12-06"",
        ""description"": ""An anthology of horror stories about roaches,\n      centipedes, scorpions  and other insects.""
      },
      {
        ""author"": ""Kress, Peter"",
        ""title"": ""Paradox Lost"",
        ""genre"": ""Science Fiction"",
        ""price"": 6.95,
        ""publish_date"": ""2000-11-02"",
        ""description"": ""After an inadvertant trip through a Heisenberg\n      Uncertainty Device, James Salway discovers the problems \n      of being quantum.""
      },
      {
        ""author"": ""O'Brien, Tim"",
        ""title"": ""Microsoft .NET: The Programming Bible"",
        ""genre"": ""Computer"",
        ""price"": 36.95,
        ""publish_date"": ""2000-12-09"",
        ""description"": ""Microsoft's .NET initiative is explored in \n      detail in this deep programmer's reference.""
      },
      {
        ""author"": ""O'Brien, Tim"",
        ""title"": ""MSXML3: A Comprehensive Guide"",
        ""genre"": ""Computer"",
        ""price"": 36.95,
        ""publish_date"": ""2000-12-01"",
        ""description"": ""The Microsoft MSXML3 parser is covered in \n      detail, with attention to XML DOM interfaces, XSLT processing, \n      SAX and more.""
      },
      {
        ""author"": ""Galos, Mike"",
        ""title"": ""Visual Studio 7: A Comprehensive Guide"",
        ""genre"": ""Computer"",
        ""price"": 49.95,
        ""publish_date"": ""2001-04-16"",
        ""description"": ""Microsoft Visual Studio 7 is explored in depth,\n      looking at how Visual Basic, Visual C++, C#, and ASP+ are \n      integrated into a comprehensive development \n      environment.""
      }
    ]
  }
}";
        }
    }
}
