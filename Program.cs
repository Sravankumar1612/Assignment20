using System;
using AssignLib;
using System.Collections.Generic;
namespace Assignment20
{
    
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
    }

    

    class Program
    {
        static void Main()
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System Menu:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choiceStr = Console.ReadLine();

                if (!int.TryParse(choiceStr, out int choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        Book newBook = new Book
                        {
                            BookId = bookId,
                            Title = title,
                            Author = author,
                            Genre = genre,
                            IsAvailable = true
                        };
                        library.AddBook(newBook);
                        Console.WriteLine("Book added successfully!");
                        break;

                    case 2:
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;

                    case 4:
                        Console.Write("Enter Book Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case 5:
                        
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}