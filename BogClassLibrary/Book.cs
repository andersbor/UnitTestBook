using System;

namespace BookClassLibrary
{
    public class Book
    {
        private string _isbn13;
        private string _title;
        private int _numberOfPages;

        // default constructor produces illegal objects
        //public Book() { }

        public Book(string title, string author, int numberOfPages, string isbn13)
        {
            Title = title; 
            Author = author; // assign to property (with check), not to backing field
            NumberOfPages = numberOfPages;
            Isbn13 = isbn13;
        }

        public string Author
        {
            get => _title;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value),"Author is null");
                }
                if (value.Length < 2)
                    throw new ArgumentException("Author must be at least 2 characters: " + value);
                _title = value;
            }
        }

        // No constraints, simple property
        public string Title { get; set; }

        public int NumberOfPages
        {
            get => _numberOfPages;
            set
            {
                if (value < 4 || value > 1000)
                    throw new ArgumentOutOfRangeException("NumberOfPages must be between 10 and 1000: " + value);
                _numberOfPages = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Isbn13 is null");
                }
                if (value.Length != 13)
                    throw new ArgumentException("ISBN must be exactly 13 characters");
                _isbn13 = value;
            }
        }
    }
}
