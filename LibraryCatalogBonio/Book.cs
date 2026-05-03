using System;

namespace LibraryCatalog.Models
{
    public class Book
    {
        // Private fields
        private string _isbn;
        private string _title;
        private string _author;
        private int _yearPublished;
        private int _copiesAvailable;

        // Public properties with validation
        public string ISBN
        {
            get => _isbn;
            set => _isbn = string.IsNullOrWhiteSpace(value) ? "000-0000000000" : value;
        }

        public string Title
        {
            get => _title;
            set => _title = string.IsNullOrWhiteSpace(value) ? "Untitled" : value;
        }

        public string Author
        {
            get => _author;
            set => _author = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
        }

        public int YearPublished
        {
            get => _yearPublished;
            set
            {
                int currentYear = DateTime.Now.Year;
                _yearPublished = (value < 1450 || value > currentYear) ? 1450 : value;
            }
        }

        public int CopiesAvailable
        {
            get => _copiesAvailable;
            set => _copiesAvailable = value < 0 ? 0 : value;
        }

        // Default constructor
        public Book()
        {
            ISBN = "000-0000000000";
            Title = "Untitled";
            Author = "Unknown";
            YearPublished = 1450;
            CopiesAvailable = 0;
        }

        // Partial constructor
        public Book(string isbn, string title, string author) : this()
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        // Full constructor
        public Book(string isbn, string title, string author, int year, int copies)
            : this(isbn, title, author)
        {
            YearPublished = year;
            CopiesAvailable = copies;
        }

        // Display details
        public string GetDetails()
        {
            return $"ISBN: {ISBN}\n" +
                   $"Title: {Title}\n" +
                   $"Author: {Author}\n" +
                   $"Year: {YearPublished}\n" +
                   $"Available Copies: {CopiesAvailable}";
        }

        // Borrow a copy
        public bool BorrowCopy()
        {
            if (CopiesAvailable <= 0) return false;

            CopiesAvailable--;
            return true;
        }

        // Return a copy
        public void ReturnCopy()
        {
            CopiesAvailable++;
        }
    }
}