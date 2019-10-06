using System;
using System.ComponentModel.DataAnnotations;

namespace BogClassLibrary
{
    public class Book
    {
        private string _isbn13;
        private string _title;
        private int _numberOfPages;

        public Book(string title, string author, int numberOfPages, string isbn13)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
            Isbn13 = isbn13;
        }

        [MinLength(2)]
        public string Title
        {
            get => _title;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Title is null");
                }
                if (value.Length < 2)
                    throw new ArgumentException("Title must be at least 2 characters: " + value);
                _title = value;
            }
        }

        // no constraints: simple property
        public string Author { get; set; }

        [Range(10, 1000)]
        public int NumberOfPages
        {
            get => _numberOfPages;
            set
            {
                if (value < 10 || value > 1000)
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
