using System;

namespace c_05
{
    class Book
    {
        // Question 1
        private string password = "secret";

        // Question 2
        internal int copiesInStock = 5;

        // Question 3
        public string Title;

        // Question 4
        public Genre Genre { get; set; }
    }

    // Question 4
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    class Program
    {
        static void Main()
        {
            Book book = new Book();



            #region Question 2 - internal
            Console.WriteLine(book.copiesInStock);
            #endregion


 
        }
    }
}