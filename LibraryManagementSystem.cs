using System;
using System.Collections.Generic;

class LibraryManagementSystem
{
    private List<string> books = new List<string>();

    public void AddBook(string title)
    {
        if (books.Count < 5)
        {
            books.Add(title);
            Console.WriteLine($"Book \"{title}\" added to the library.");
        }
        else
        {
            Console.WriteLine("Library is full. Cannot add more books.");
        }
    }

    public void RemoveBook(string title)
    {
        if (books.Contains(title))
        {
            books.Remove(title);
            Console.WriteLine($"Book \"{title}\" removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book \"{title}\" not found in the library.");
        }
    }

    public void DisplayBooks()
    {
        if (books.Count > 0)
        {
            Console.WriteLine("Books currently in the library:");
            foreach (string book in books)
            {
                Console.WriteLine($"- {book}");
            }
        }
        else
        {
            Console.WriteLine("No books in the library.");
        }
    }
}

class Program
{
    /*static void Main()
    {
        LibraryManagementSystem library = new LibraryManagementSystem();
        
        while (true)
        {
            Console.WriteLine("\nChoose an action: add, remove, display, exit");
            string action = Console.ReadLine().Trim().ToLower();

            if (action == "add")
            {
                Console.Write("Enter the title of the book to add: ");
                string title = Console.ReadLine().Trim();
                library.AddBook(title);
            }
            else if (action == "remove")
            {
                Console.Write("Enter the title of the book to remove: ");
                string title = Console.ReadLine().Trim();
                library.RemoveBook(title);
            }
            else if (action == "display")
            {
                library.DisplayBooks();
            }
            else if (action == "exit")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please try again.");
            }
        }
    }*/
}