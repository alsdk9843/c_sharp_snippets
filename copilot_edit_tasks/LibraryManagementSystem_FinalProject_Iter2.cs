using System;

class LibraryManager_FinalProject_Iter2
{
    /*static void Main()
    {
        // Array to store book titles
        string[] books = new string[5];
        int borrowedBooks = 0;
        const int maxBorrowedBooks = 3;

        while (true)
        {
            Console.WriteLine("Would you like to add, remove, search, or borrow a book? (add/remove/search/borrow/exit)");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                AddBook(books);
            }
            else if (action == "remove")
            {
                RemoveBook(books);
            }
            else if (action == "search")
            {
                SearchBook(books);
            }
            else if (action == "borrow")
            {
                if (borrowedBooks < maxBorrowedBooks)
                {
                    BorrowBook(books, ref borrowedBooks);
                }
                else
                {
                    Console.WriteLine($"You can only borrow up to {maxBorrowedBooks} books at once.");
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'search', 'borrow', or 'exit'.");
            }

            // Display the list of books
            DisplayBooks(books);
        }
    }*/

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
    static void RemoveBook(string[] books)
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
                    break;
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

    // Method to borrow a book from the library
    static void BorrowBook(string[] books, ref int borrowedBooks)
    {
        Console.WriteLine("Enter the title of the book to borrow:");
        string borrowBook = Console.ReadLine();

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == borrowBook)
            {
                books[i] = "";
                borrowedBooks++;
                Console.WriteLine($"You have borrowed '{borrowBook}'.");
                break;
            }
        }
    }

    // Method to display the list of books
    static void DisplayBooks(string[] books)
    {
        Console.WriteLine("Available books:");
        foreach (string book in books)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine(book);
            }
        }
    }
}