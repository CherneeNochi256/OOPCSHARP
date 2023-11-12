using Lab6;

public class Program
{
    private static void Main()
    {
        var book = new Book("Title", "Author", 9.99);
        book.Print();

        Console.WriteLine();

        var genreBook = new GenreBook("Title", "Author", 9.99, "Fantasy");
        genreBook.Print();

        Console.WriteLine();

        var publisherBook = new PublisherBook("Title", "Author", 9.99, "Fantasy", "Publisher");
        publisherBook.Print();
    }
}