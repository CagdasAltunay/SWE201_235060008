using System;

namespace BookLibrary
{
    public class Book
    {
        // Üye değişkenler
        private string _title;
        private string _author;
        private int _pageCount;
        private string _isbn;

        // Property'ler (gereksinim: en az iki tane)
        public string Title
        {
            get => _title;
            set => _title = value ?? "";
        }

        public string Author
        {
            get => _author;
            set => _author = value ?? "";
        }

        public int PageCount
        {
            get => _pageCount;
            set => _pageCount = value >= 0 ? value : 0;
        }

        public string ISBN
        {
            get => _isbn;
            set => _isbn = value ?? "";
        }

        // Boş constructor
        public Book()
        {
            _title = "";
            _author = "";
            _pageCount = 0;
            _isbn = "";
        }

        // Parametreli constructor
        public Book(string title, string author, int pageCount, string isbn)
        {
            _title = title ?? "";
            _author = author ?? "";
            _pageCount = pageCount;
            _isbn = isbn ?? "";
        }

        // ToString override (gereksinim)
        public override string ToString()
        {
            return $"{Title} - {Author} ({PageCount} pages) [ISBN: {ISBN}]";
        }

        // Ek fonksiyon (opsiyonel)
        public bool IsLongBook()
        {
            return PageCount > 300;
        }
    }
}
