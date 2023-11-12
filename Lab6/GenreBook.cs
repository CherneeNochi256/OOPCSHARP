namespace Lab6;

public class GenreBook : Book
{
    public GenreBook(string title, string author, double price, string genre) : base(title, author, price)
    {
        this.Genre = genre;
    }

    public string Genre { get; set; }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Genre: {Genre}");
    }
}