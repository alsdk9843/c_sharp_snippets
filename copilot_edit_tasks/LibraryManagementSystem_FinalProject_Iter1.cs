using System;

class LibraryManager_FinalProject_Iter1
{
    /*static void Main()
    {
        // Array to store book titles
        string[] books = new string[5];

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                AddBook(books);
            }
            else if (action == "remove")
            {
                RemoveBook(books);
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
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