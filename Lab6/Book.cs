namespace Lab6;

public class Book
{
    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title { get; set; }

    public string Author { get; set; }

    public double Price { get; set; }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: {Price}");
    }
}