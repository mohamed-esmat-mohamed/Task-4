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


            #region Question 6 - int to Enum
            int genreNumber = 1;

            Genre genreValue = (Genre)genreNumber;

            Console.WriteLine(genreValue);
            #endregion


            #region Question 7 - Enum to String
            Genre genre = Genre.Fiction;

            string genreText = genre.ToString();

            Console.WriteLine(genreText);
            #endregion


            #region Question 8 - String to Enum using Parse
            string genreText2 = "Science";

            Genre parsedGenre = Enum.Parse<Genre>(genreText2);

            Console.WriteLine(parsedGenre);
            #endregion


            #region Question 9 - String to Enum using TryParse
            string genreText3 = "Mystery";

            if (Enum.TryParse<Genre>(genreText3, out Genre result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion

        }
    }
}