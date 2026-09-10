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
            #region Question 3 - public
            book.Title = "C# Basics";
            Console.WriteLine(book.Title);
            #endregion


            #region Question 4 - Enum Property
            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);
            #endregion


            #region Question 5 - Enum to int
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion



        }
    }
}