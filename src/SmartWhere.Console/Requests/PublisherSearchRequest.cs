﻿using SmartWhere.Attributes;
using SmartWhere.Interfaces;

namespace SmartWhere.Console.Requests
{
    public class PublisherSearchRequest : IWhereClause
    {
        //[WhereClause(PropertyName = "Id")]
        //public int PublisherId { get; set; }

        //[WhereClause]
        //public string Name { get; set; }

        //[WhereClause("Book.Name")]
        //public string BookName { get; set; }

        //[WhereClause("Books.Author.Name")]
        //public string AuthorName { get; set; }

        [WhereClause("Book.Author.Country.Name")]
        public string Name { get; set; }
    }
}
