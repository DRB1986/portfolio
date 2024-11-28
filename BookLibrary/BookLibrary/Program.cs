using System;
using System.Collections.Generic;

//Define IBook interface
public interface IBook
{
    void MarkAsBorrowed();
    void MarkAsReturned();
    string GetLocation();
    string Title { get; set; }
    bool IsBorrowed { get; set; }
    string Location { get; set; }
}

//Implement IBook interface in the Ebook class
public class Ebook : IBook
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string Location { get; set; }

    public Ebook(string title)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        IsBorrowed = false;
        Location = "Web";
    }

    public void MarkAsBorrowed()
    {
        IsBorrowed = true;
    }

    public void MarkAsReturned()
    {
        IsBorrowed = false;
    }

    public string GetLocation()
    {
        return Location;
    }
}

//Implement the IBook interface in the HardCover class
public class HardCover : IBook
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string Location { get; set; }

    public HardCover(string title)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        IsBorrowed = false;
        Location = "Library";
    }

    public void MarkAsBorrowed()
    {
        IsBorrowed = true;
        Location = "Client";
    }

    public void MarkAsReturned()
    {
        IsBorrowed = false;
        Location = "Library";
    }

    public string GetLocation()
    {
        return Location;
    }
}

//Implement the IBook interface in the AudioBook class
public class AudioBook : IBook
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string Location { get; set; }

    public AudioBook(string title)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        IsBorrowed = false;
        Location = "Web";
    }

    public void MarkAsBorrowed()
    {
        IsBorrowed = true;
    }

    public void MarkAsReturned()
    {
        IsBorrowed = false;
    }

    public string GetLocation()
    {
        return Location;
    }
}

//Main program to demonstrate the functionality of the library system
public class Program
{
    private static List<IBook> library = new List<IBook>();

    public static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Add a new book");
            Console.WriteLine("2 - Find a book");
            Console.WriteLine("3 - Borrow a book");
            Console.WriteLine("4 - Return a book");
            Console.Write("Your choice: ");
            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                case 1:
                    AddNewBook();
                    break;
                case 2:
                    FindBook();
                    break;
                case 3:
                    BorrowBook();
                    break;
                case 4:
                    ReturnBook();
                    break;
                default:
                    Console.WriteLine("This operation is not supported, please try again.");
                    break;
            }
        } while (choice != 0);
    }

    private static void AddNewBook()
    {
        Console.Write("Enter the book type (Ebook, HardCover, AudioBook): ");
        string? type = Console.ReadLine();
        Console.Write("Enter the book title: ");
        string? title = Console.ReadLine();

        if (type == null || title == null)
        {
            Console.WriteLine("Type or title cannot be null.");
            return;
        }

        IBook newBook;
        switch (type.ToLower())
        {
            case "ebook":
                newBook = new Ebook(title);
                break;
            case "hardcover":
                newBook = new HardCover(title);
                break;
            case "audiobook":
                newBook = new AudioBook(title);
                break;
            default:
                Console.WriteLine("Invalid book type.");
                return;
        }

        library.Add(newBook);
        Console.WriteLine($"The book '{title}' has been added to the library.");
    }

    private static void FindBook()
    {
        Console.Write("Enter the book title: ");
        string? title = Console.ReadLine();

        if (title == null)
        {
            Console.WriteLine("Title cannot be null.");
            return;
        }

        IBook? book = library.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            string status = book.IsBorrowed ? "borrowed" : "available";
            Console.WriteLine($"The book '{title}' is {status}.");
        }
        else
        {
            Console.WriteLine($"The book '{title}' does not exist in the library.");
        }
    }

    private static void BorrowBook()
    {
        Console.Write("Enter the book title: ");
        string? title = Console.ReadLine();

        if (title == null)
        {
            Console.WriteLine("Title cannot be null.");
            return;
        }

        IBook? book = library.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine($"The book '{title}' is already borrowed.");
            }
            else
            {
                book.MarkAsBorrowed();
                Console.WriteLine($"You have borrowed the book '{title}'.");
            }
        }
        else
        {
            Console.WriteLine($"The book '{title}' does not exist in the library.");
        }
    }

    private static void ReturnBook()
    {
        Console.Write("Enter the book title: ");
        string? title = Console.ReadLine();

        if (title == null)
        {
            Console.WriteLine("Title cannot be null.");
            return;
        }

        IBook? book = library.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            if (!book.IsBorrowed)
            {
                Console.WriteLine($"The book '{title}' is not borrowed.");
            }
            else
            {
                book.MarkAsReturned();
                Console.WriteLine($"You have returned the book '{title}'.");
            }
        }
        else
        {
            Console.WriteLine($"The book '{title}' does not exist in the library.");
        }
    }
}
