using System;

namespace ECommerce.Common
{
    public class ECommerceConstants
    {
        private const string prefix = "ec_";

        //db tables
        public const string BOOKS_TABLE = prefix + "books";
        public const string AUTHOR_TABLE = prefix + "authors";
        public const string BOOKAUTHOR_TABLE = prefix + "bookAuthors";
        public const string CATEGORY_TABLE = prefix + "categories";
        public const string PRICE_TABLE = prefix + "prices";
        public const string PUBLISHER_TABLE = prefix + "publishers";
    }
}
