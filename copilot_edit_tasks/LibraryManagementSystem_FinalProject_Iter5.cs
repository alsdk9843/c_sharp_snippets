
using System;

class LibraryManager_FinalProject_Iter5
{
    static void Main()
    {
        // Array to store book titles
        string[] books = new string[5];
        // Array to store checked-out status
        bool[] borrwed = new bool[5];
        int borrowedBooks = 0;
        const int maxBorrowedBooks = 3;

        while (true)
        {
            Console.WriteLine("Would you like to add, remove, search, borrow / check out, check in a book, or exit? (add/remove/search/borrow/checkin/exit)");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                AddBook(books);
            }
            else if (action == "remove")
            {
                RemoveBook(books, borrwed);
            }
            else if (action == "search")
            {
                SearchBook(books);
            }
            else if (action == "borrow")
            {
                if (borrowedBooks < maxBorrowedBooks)
                {
                    borrowBook(books, borrwed, ref borrowedBooks);
                }
                else
                {
                    Console.WriteLine($"You can only borrow up to {maxBorrowedBooks} books at once.");
                }
            }
            else if (action == "checkin")
            {
                CheckInBook(books, borrwed);
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'borrow', 'checkin', or 'exit'.");
            }

            // Display the list of books
            DisplayBooks(books, borrwed);
        }
    }

    // Method to add a book to the library
    static void AddBook(string[] books)
    {
        if (Array.Exists(books, book => string.IsNullOrEmpty(book)))
        {
            Console.WriteLine("Enter the title of the book to add:");
            string newBook = Console.ReadLine();

            for (int i = 0; i < books.Length; i++)
            {
                if (string.IsNullOrEmpty(books[i]))
                {
                    books[i] = newBook;
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("The library is full. No more books can be added.");
        }
    }

    // Method to remove a book from the library
    static void RemoveBook(string[] books, bool[] borrwed)
    {
        if (Array.Exists(books, book => !string.IsNullOrEmpty(book)))
        {
            Console.WriteLine("Enter the title of the book to remove:");
            string removeBook = Console.ReadLine();

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == removeBook)
                {
                    books[i] = "";
                    borrwed[i] = false;
                    break;
                }
                else if (books[i] != removeBook)
                {
                    Console.WriteLine("Book not found. Please re-check the title of the book.");
                }
            }
        }
        else
        {
            Console.WriteLine("The library is empty. No books to remove.");
        }
    }

    // Method to search for a book by its title
    static void SearchBook(string[] books)
    {
        Console.WriteLine("Enter the title of the book to search:");
        string searchBook = Console.ReadLine();

        bool found = false;
        foreach (string book in books)
        {
            if (book == searchBook)
            {
                Console.WriteLine($"Book '{searchBook}' is available in the library.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Book '{searchBook}' is not available in the library.");
        }
    }

    // Method to borrow / check out a book from the library
    static void borrowBook(string[] books, bool[] borrwed, ref int borrowedBooks)
    {
        if (Array.Exists(books, book => !string.IsNullOrEmpty(book) && !borrwed[Array.IndexOf(books, book)]))
        {
            Console.WriteLine("Enter the title of the book to borrow / check out:");
            string borrowBook = Console.ReadLine();

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == borrowBook && !borrwed[i])
                {
                    borrwed[i] = true;
                    borrowedBooks++;
                    Console.WriteLine($"The book '{borrowBook}' has been borrowed / checked out.");
                    break;
                }
                else if (books[i] == borrowBook && borrwed[i])
                {
                    Console.WriteLine($"The book '{borrowBook}' is already checked out.");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("No available books to borrow / check out.");
        }
    }

    // Method to check in a book to the library
    static void CheckInBook(string[] books, bool[] borrwed)
    {
        if (Array.Exists(borrwed, status => status))
        {
            Console.WriteLine("Enter the title of the book to check in:");
            string checkInBook = Console.ReadLine();

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == checkInBook && borrwed[i])
                {
                    borrwed[i] = false;
                    Console.WriteLine($"The book '{checkInBook}' has been checked in.");
                    break;
                }
                else if (books[i] == checkInBook && !borrwed[i])
                {
                    Console.WriteLine($"The book '{checkInBook}' is not borrowed / checked out.");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("No books are currently checked out.");
        }
    }

    // Method to display the list of books
    static void DisplayBooks(string[] books, bool[] borrwed)
    {
        Console.WriteLine("Available books:");
        for (int i = 0; i < books.Length; i++)
        {
            if (!string.IsNullOrEmpty(books[i]) && !borrwed[i])
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}