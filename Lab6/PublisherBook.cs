namespace Lab6;

public sealed class PublisherBook : GenreBook
{
    public PublisherBook(string title, string author, double price, string genre, string publisher) : base(title,
        author, price, genre)
    {
        this.Publisher = publisher;
    }

    public string Publisher { get; set; }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Publisher: {Publisher}");
    }
}